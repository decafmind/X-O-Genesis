using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Randy.GraphicsLibrary;
using MyExtension;
using System.Drawing.Printing;

namespace PetvetPOS_Inventory_System
{
    public partial class InventoryView : MyUserControl, IContentPage, IKeyController
    {
        // TODO
        // ProductPaneScroll productPaneScroll;
        ProductSliderPane sliderPane;
        DataTable inventoryTable;

        private const int PRODUCT_NAME_INDEX = 0;
        private const int PRODUCT_DESCRIPTION_INDEX = 1;
        private const int QUANTITY_ONHAND_INDEX = 2;
        private const int MAINTAINING_STOCKS_INDEX = 3;
       

        public int currentSelection;
        string barcode;

        DataGridViewCellStyle critical, normal, highlighted;

        private enum SelectedTab
        {
            Product,
            Service,
        }

        public InventoryView()
        {
            InitializeComponent();
        }

        public InventoryView(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
            this.masterController.EmployeeLogin += masterController_EmployeeLogin;
            this.dbController = masterController.DataBaseController;
            sliderPane = productSliderPane1;
            sliderPane.accessMasterController = masterController;
            sliderPane.dbController = masterController.DataBaseController;
            sliderPane.inventoryView = this;

            using (Font timesNewRoman = new Font("Times New Roman", 12, FontStyle.Regular))
            {
                critical = new DataGridViewCellStyle()
                {
                    Font = timesNewRoman,
                    BackColor = Color.DarkRed,
                    ForeColor = Color.White,
                    SelectionBackColor = SystemColors.inventoryRosy,
                    SelectionForeColor = Color.Black,
                };

                normal = new DataGridViewCellStyle()
                {
                    Font = timesNewRoman,
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    SelectionBackColor = Color.Silver,
                    SelectionForeColor = Color.White,
                };
            }

            highlighted = new DataGridViewCellStyle()
            {
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
            };

            dgInventory.DefaultCellStyle.ApplyStyle(normal);
        }

        void masterController_EmployeeLogin(object sender, EmployeeArgs e)
        {
            if (masterController.LoginEmployee.Position != UserLevel.ADMIN)
            {
                this.updateKeyPanel.Visible = false;
                this.addKeyPanel.Visible = false;
            }
        }


        public void initializePage()
        {
            tabPage1.Select();
            txtSearch.Enabled = true;          

            fillgdInventory();

            dbController.UpdateEntity += dbController_UpdateEntity;
            dbController.InsertEntity += dbController_InsertEntity;
            dbController.DeleteEntity += dbController_DeleteEntity;

            txtSearch.Focus();
            cbCategory.Items.AddRange(dbController.categoryMapper.getListOfCategory().ToArray());
            cbCategory.Items.Add("ALL");

        }

        public void finalizePage()
        {
            dbController.UpdateEntity -= dbController_UpdateEntity;
            dbController.InsertEntity -= dbController_InsertEntity;
            dbController.DeleteEntity -= dbController_DeleteEntity;
        }

        void dbController_DeleteEntity(object sender, EntityArgs e)
        {
            throw new NotImplementedException();
        }

        void dbController_InsertEntity(object sender, EntityArgs e)
        {
            fillgdInventory();
            IEntity entity = e.Entity;

            string nameField = string.Empty, message = string.Empty, action = string.Empty, petsize = string.Empty;

            if (entity is Product)
            {
                Product p = entity as Product;
                nameField = p.Name;

                message = string.Format("New product: {0} has been added", nameField);
                action = string.Format("has added a new product", nameField);
            }
            else if (entity is Inventory)
            {
                Inventory i = entity as Inventory;
                Product p = dbController.getProductFromBarcode(i.Barcode);
                nameField = p.Name;

                message = string.Format("New stock of product {0} has been added", nameField);
                action = string.Format("added a new stock of product", nameField);
            }
            
            MessageBanner banner = new MessageBanner(message, 2000);
            banner.Show();
            dbController.insertAuditTrail(action);
        }

        void highlighRowOfDatagridView(params string[] args)
        {
            if (args.Length < 1)
                return;

            const int NAME_INDEX = 0;

            foreach (DataGridViewRow row in dgInventory.Rows)
            {
                if (args.Length > 1)
                {
                    if (row.Cells[NAME_INDEX].Value.ToString() == args[0])
                    {
                        row.Selected = true;
                        break;
                    }
                }
                else
                {
                    if (row.Cells[NAME_INDEX].Value.ToString() == args[0])
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }

        void dbController_UpdateEntity(object sender, EntityArgs e)
        {
            fillgdInventory();
            IEntity entity = e.Entity;

            string message = string.Empty, action = string.Empty, nameField = string.Empty, petsize = string.Empty;

            if (entity is Product)
            {
                Product p = entity as Product;
                nameField = p.Name;
                message = string.Format("Product {0} has been updated", nameField);
                action = string.Format("has updated the product {0}", nameField);
            }
            
            MessageBanner banner = new MessageBanner(message, 3000);
            banner.Show();
            dbController.insertAuditTrail(action);

        }


        public void fillgdInventory()
        {
            inventoryTable = new DataTable();
            if (rbInventory.Checked)
                dbController.readInventory(inventoryTable);
            else if (rbPurchased.Checked)
                dbController.readPurchasedProduct(inventoryTable);
            else if (rbArchives.Checked)
                dbController.showArchives(inventoryTable);

            dgInventory.DataSource = inventoryTable;
            dgInventory.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgInventory.Focus();

            if (rbInventory.Checked)
                colorCodedRows();
            else if (rbPurchased.Checked)
                highlightQtySoldCells();

            string product_name, product_desc;

            if (rbInventory.Checked)
            {
                foreach (DataGridViewRow row in dgInventory.Rows)
                {
                    int noOfCriticalProducts = 0;
                    product_name = (string)row.Cells[PRODUCT_NAME_INDEX].Value;
                    product_desc = (string)row.Cells[PRODUCT_DESCRIPTION_INDEX].Value;
                    Product product = dbController.productMapper.getProductFromNameAndDesc(product_name, product_desc);
                    if (rbInventory.Checked && mainTab.SelectedTab == tabPage1){
                        if (dbController.productInventory.checkIfProductIsCritical(product))
                        {
                            noOfCriticalProducts += 1;
                        }
                    }
                    if (noOfCriticalProducts > 0)
                        masterController.displayCriticalNotif(noOfCriticalProducts);
                }
            }
        }

        public void filterdgInventory(string token, bool categoryOnly = false)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                fillgdInventory();
                txtSearch.Focus();
            }
            else
            {
                inventoryTable = new DataTable();

                if (rbInventory.Checked){
                    if (categoryOnly)
                        dbController.filterInventory(inventoryTable, token, true);
                    else
                        dbController.filterInventory(inventoryTable, token);
                }
                else if (rbPurchased.Checked){
                    dbController.filterPurchasedProduct(inventoryTable, token);
                }
                dgInventory.DataSource = inventoryTable;

                if (rbInventory.Checked)
                    colorCodedRows();
                else if (rbPurchased.Checked)
                    highlightQtySoldCells();
            }

        }

        void colorCodedRows()
        {
            try
            {
                int qty_onhand, maintainingStocks;
                foreach (DataGridViewRow row in dgInventory.Rows)
                {
                    qty_onhand = (int)(decimal)row.Cells[QUANTITY_ONHAND_INDEX].Value;
                    maintainingStocks = (int)row.Cells[MAINTAINING_STOCKS_INDEX].Value;

                    if (qty_onhand <= maintainingStocks)
                        row.DefaultCellStyle.ApplyStyle(critical);

                    row.Cells[QUANTITY_ONHAND_INDEX].Style = highlighted;
                }
            }catch(Exception ex){

            }
            
        }

        void highlightQtySoldCells()
        {
            int qty_sold_index = 0;
            int n = dgInventory.Columns.Count;
            for (int i = 0; i < n; i++)
            {
                if (dgInventory.Columns[i].HeaderText == "Qty Sold")
                    qty_sold_index = i;
            }

            foreach (DataGridViewRow row in dgInventory.Rows)
                row.Cells[qty_sold_index].Style = highlighted;
        }

        public Menu accessMenuName
        {
            get
            {
                return Menu.Stock_Control;
            }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.inventoryWhite; }
        }

        
        public string Barcode { get { return barcode; } set { barcode = value; } }
        private void Inventory_KeyFunction(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (mainTab.SelectedTab == tabPage1)
                {
                    keyButton6.updateButton();
                    modalInspectProduct inspect = new modalInspectProduct(dbController);
                    inspect.bcode = getBarcodeFromRow();
                    inspect.ShowDialog();   
                }
                else
                {
                    toogleSearchTransaction();
                    keyButton10.updateButton();
                }

            }
            else if (e.Shift && e.KeyCode == Keys.F2)
            {
                if (masterController.LoginEmployee.Position == UserLevel.ADMIN)
                {
                    dbController.productMapper.deactiveProduct(getBarcodeFromRow());
                    fillgdInventory();
                }
                else
                {
                    MessageBox.Show("You must be the admin to remove product.");
                }
                
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (mainTab.SelectedTab == tabPage1)
                {
                    if (masterController.LoginEmployee.Position == UserLevel.ADMIN)
                    {
                        keyButton9.updateButton();
                        currentSelection = dgInventory.CurrentCell.RowIndex;
                        updateProduct();
                        dgInventory.Rows[currentSelection].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("You must be the admin to update product.");
                    }
                }
                else
                {
                    keyButton11.updateButton();
                    toggleReturnQty();
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (masterController.LoginEmployee.Position == UserLevel.ADMIN)
                {
                    keyButton8.updateButton();
                    currentSelection = dgInventory.CurrentCell.RowIndex;
                    addProduct();
                    dgInventory.Rows[currentSelection].Selected = true;
                }
                else
                {
                    MessageBox.Show("You must be the admin to add product");
                }
                
                
            }
            else if (e.KeyCode == Keys.F4)
            {
                addStocks();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                if (mainTab.SelectedTab == tabPage1)
                {
                    keyButton11.updateButton();
                    keyButton7.updateButton();
                    if (rbInventory.Checked || rbPurchased.Checked)
                        print();
                }
                else
                {
                    keyButton13.updateButton();
                    keyButton14.updateButton();
                    printReceipt();
                }
            }

           
            if (sliderPane.isOpen())
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape){
                    if (sliderPane.OK())
                    {
                        toogleSearch();
                    }          
                }
            }

        }

        void addStocks()
        {
            string barcode = getBarcodeFromRow();

            ProductInventoryDomain productInventoryDomain = dbController.productInventory.getProductInventoryThroughBarcode(barcode);
            modalAddStocks addStocks = new modalAddStocks(productInventoryDomain.product.Barcode,
                                                    productInventoryDomain.product.Name,
                                                    productInventoryDomain.inventory.QtyOnHand);

            DialogResult result = addStocks.ShowDialog();

            if (result == DialogResult.OK)
            {
                Inventory inventory = new Inventory()
                {
                    Barcode = barcode,
                    StockinDateTime = DateTime.Now,
                    QtyReceived = addStocks.AdditionalStocks,
                    QtyOnHand = addStocks.AdditionalStocks,
                };

                dbController.insertInventory(inventory);
            }
            fillgdInventory();
        }

        void smartFocus()
        {
            if (txtSearch.Enabled){
                txtSearch.Clear();
                txtSearch.Focus();
            }else{
                dgInventory.Focus();
            }
        }
        /// <summary>
        /// This properties return the KeyFunction that will be fetch by the main form
        /// </summary>
        public KeyFunction getKeyController
        {
            get
            {
                return new KeyFunction(Inventory_KeyFunction);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toogleSearch();
        }

        void toogleSearch()
        {
            if (txtSearch.Enabled)
            {
                txtSearch.Clear();
                txtSearch.Enabled = false;
                fillgdInventory();
              
            }
            else
            {
                if (sliderPane.isOpen())
                    sliderPane.hide();
                txtSearch.Enabled = true;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        void addProduct()
        {
            sliderPane.clearTexts();

            if (!sliderPane.isOpen())
                sliderPane.toggle(InventoryMode.ADD);
            toogleSearch();
        }

        private void txtSearch_EnabledChanged_1(object sender, EventArgs e)
        {
            if (txtSearch.Enabled)
            {
                txtSearch.Focus();
            }
        }


        private void dgInventory_Sorted(object sender, EventArgs e)
        {
            if (rbInventory.Checked)
                colorCodedRows();
            if (rbPurchased.Checked)
                highlightQtySoldCells();
        }

        private void checkChanged(object sender, EventArgs e)
        {
            RadioButton cb = sender as RadioButton;

            if (cb.Checked)
            {
                cb.FlatAppearance.CheckedBackColor = SystemColors.jetBlackTitleBar;
                cb.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                cb.FlatAppearance.CheckedBackColor = Color.Silver;
                cb.ForeColor = SystemColors.jetBlackTitleBar;
            }

            fillgdInventory();
        }

        private void deleteProduct(string barcode)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product, this command is irreversible",
                "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dbController.productMapper.deactiveProduct(barcode))
                {
                    MessageBanner banner = new MessageBanner("Product has been removed");
                    banner.Show(this);
                    fillgdInventory();
                }
            }
        }

        private void search(string token)
        {
            filterdgInventory(token);
        }

        void updateProduct()
        {    
            string product_name = string.Empty;
            product_name = getValueFromDatagridCell(PRODUCT_NAME_INDEX);
            Product product = dbController.getProductThroughName(product_name);
            if (product.Barcode != null)
            {
                productSliderPane1.mapProductToTextfield(product);       
                if (!productSliderPane1.isOpen())
                    productSliderPane1.toggle(InventoryMode.UPDATE);
                toogleSearch();
            }
            else
            {
                MessageBox.Show("No product selected");
            }
        }

        string getValueFromDatagridCell(int index)
        {
            string cellValue = string.Empty;
            if (dgInventory.SelectedRows.Count != 0)
                cellValue = dgInventory.SelectedRows[0].Cells[index].Value.ToString();
            return cellValue;
        }

        object getValueFromDatagridCell(DataGridView dgV, int row_index, int cell_index)
        {
            return dgV.Rows[row_index].Cells[cell_index].Value;
        }

        void print()
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += document_PrintPage;

            PrintPreviewDialog dialog = new PrintPreviewDialog()
            {
                Width = 600,
                Height = 800,
            };

            dialog.Document = document;
            dialog.ShowDialog();
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Font arialRoundedMt = new Font("Arial Rounded MT", 16, FontStyle.Italic))
            using (Font arial = new Font("Arial", 14, FontStyle.Bold))
            using (Font timesNewRoman = new Font("Times New Roman", 14, FontStyle.Regular))
            {
                string title = "";
                if (rbInventory.Checked)
                    title = "INVENTORY REPORT";
                else if (rbPurchased.Checked)
                    title = "PURCHASED PRODUCT REPORT";

                int Y = 50;

                int documentWidth = e.PageBounds.Width;
                int documentHeight = e.PageBounds.Height;

                // Draw title
                SizeF stringSize = g.MeasureString(title, arialRoundedMt);
                g.DrawString(title, arialRoundedMt, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + 10;

                string petvetStore = "Exogenesis";
                stringSize = g.MeasureString(petvetStore, arialRoundedMt);
                g.DrawString(petvetStore, arialRoundedMt, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + 10;

                string addressL1 = "2/f Nova Square Shopping Center,";
                string addressL2 = "San Bartolome, Nova. Q.C.";

                stringSize = g.MeasureString(addressL1, arialRoundedMt);
                g.DrawString(addressL1, arialRoundedMt, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + 10;

                stringSize = g.MeasureString(addressL2, arialRoundedMt);
                g.DrawString(addressL2, arialRoundedMt, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + 10;

                string dateToday = DateTime.Today.ToLongDateString();
                stringSize = g.MeasureString(dateToday, arialRoundedMt);
                g.DrawString(dateToday, arialRoundedMt, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + 10;

                g.DrawLine(new Pen(Brushes.Black), new PointF(50, Y), new PointF((documentWidth - 50), Y));
                Y += 10;

                //Draw Headers
                int numberOfColumns = dgInventory.Columns.Count;
                string[] headers = new string[numberOfColumns];
                for (int i = 0; i < numberOfColumns; i++)
                    headers[i] = dgInventory.Columns[i].HeaderText;

                int documentWithMargin = documentWidth + 50;

                g.DrawString(headers[0], arial, Brushes.Black, new PointF(50, Y));
                g.DrawString(headers[1], arial, Brushes.Black, new PointF((documentWithMargin * (float).25) + 100, Y));
                g.DrawString(headers[2], arial, Brushes.Black, new PointF((documentWithMargin * (float).50) + 100, Y));
                stringSize = g.MeasureString(headers[3], arial);
                g.DrawString(headers[3], arial, Brushes.Black, new PointF((documentWidth - stringSize.Width - 50), Y));
                Y += (int)stringSize.Height + 10;

                // Draw data
                foreach (DataGridViewRow row in dgInventory.Rows)
                {
                    string field1 = row.Cells[0].Value.ToString();
                    string field2 = row.Cells[1].Value.ToString();
                    string field3 = row.Cells[2].Value.ToString();
                    string field4 = "";
                    if (row.Cells[3].Value is DateTime)
                    {
                        DateTime foo = (DateTime)row.Cells[3].Value;
                        field4 = foo.Date.ToShortDateString();
                    }
                    else
                    {
                        field4 = row.Cells[3].Value.ToString();
                    }

                    g.DrawString(field1, timesNewRoman, Brushes.Black, new PointF(50, Y));
                    g.DrawString(field2, timesNewRoman, Brushes.Black, new PointF((documentWithMargin * (float).25) + 100, Y));
                    g.DrawString(field3, timesNewRoman, Brushes.Black, new PointF((documentWithMargin * (float).50) + 100, Y));
                    stringSize = g.MeasureString(field4, timesNewRoman);
                    g.DrawString(field4, timesNewRoman, Brushes.Black, new PointF((documentWidth - stringSize.Width - 50), Y));

                    stringSize = g.MeasureString(field1, timesNewRoman);
                    Y += (int)stringSize.Height + 10;
                }
            }
        }

        private void parentPanel_Resize(object sender, EventArgs e)
        {
            bottomPanel.Location = new Point((parentPanel.Width - bottomPanel.Width) / 2, bottomPanel.Location.Y);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            searchTransaction();
        }

        int parseTransactionNo()
        {
            if (!string.IsNullOrWhiteSpace(txtTransactionno.Text))
            {
                if (txtTransactionno.Text.Contains("PV-"))
                {
                    string[] foo = txtTransactionno.Text.Split('-');
                    if (foo.Length == 2)
                        return int.Parse(foo[1]);
                }
                else
                {
                    return int.Parse(txtTransactionno.Text);
                }
            }

            return 0;
        }


        void searchTransaction()
        {
            if (!string.IsNullOrWhiteSpace(txtTransactionno.Text))
            {
                string transctionNo = "0";
                if (txtTransactionno.Text.Contains("PV-"))
                {
                    string[] foo = txtTransactionno.Text.Split('-');
                    if (foo.Length == 2)
                        transctionNo = foo[1];
                }
                else
                {
                    transctionNo = txtTransactionno.Text;
                }


                int bar = 0;
                if (int.TryParse(transctionNo, out bar))
                {
                    dgProductTransaction.DataSource = dbController.getProductTransactionFromTransactionID(bar.ToString());
                    computeTotalPrice();
                }

            }
        }

        void toogleSearchTransaction()
        {
            if (txtTransactionno.Enabled)
                txtTransactionno.Enabled = false;
            else
                txtTransactionno.Enabled = true;
        }

        void computeTotalPrice()
        {
            int SUBTOTAL_INDEX = 3;
            decimal total = 0M;

            foreach (DataGridViewRow row in dgProductTransaction.Rows)
                total += (decimal)row.Cells[SUBTOTAL_INDEX].Value;
           
            lblAmount.Text = total.ToString();
        }

        private void txtTransactionno_Enter(object sender, EventArgs e)
        {
            masterController.setFormReturnkey = btnOK;
        }

        void toggleReturnQty()
        {
            if (txtQty.Enabled)
                txtQty.Enabled = false;
            else
                txtQty.Enabled = true;
        }

        private void txtQty_EnabledChanged(object sender, EventArgs e)
        {
            if (txtQty.Enabled)
            {
                txtQty.Focus();
                masterController.setFormReturnkey = btnConfirm;
            }
        }

        private void txtTransactionno_EnabledChanged(object sender, EventArgs e)
        {
            if (txtTransactionno.Enabled)
            {
                txtTransactionno.Focus();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            editDataGrid(); 
        }

        void updateProductTransaction(string name, int transaction_id, int qty, decimal grp_price)
        {

            Product product = dbController.getProductThroughName(name);
            Invoice transaction = new Invoice()
            {
                InvoiceId = transaction_id,
            };

            ProductInvoice productInvoice = new ProductInvoice()
            {
                product = product,
                invoice = transaction,
                QuantitySold = -qty,
                GroupPrice = grp_price,
            };

            int quantity = 0;
            if (int.TryParse(getValueFromDatagridCell(2), out quantity))
            {
                if (qty > quantity)
                    return;
            }

            dbController.insertProductInvoice(productInvoice);

        }

        void editDataGrid()
        {
            InputDialog inputDialog = new InputDialog("Product Return", "Reason for return");
            DialogResult result = inputDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                const int DESC_INDEX = 0;
                const int UNIT_PRICE_INDEX = 1;
                const int QUANTITY_INDEX = 2;
                const int GROUP_PRICE_INDEX = 3;

                if (dgProductTransaction.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dgProductTransaction.SelectedRows[0];
                    string desc = getValueFromDatagridCell(dgProductTransaction, row.Index, DESC_INDEX).ToString();

                    int old_qty = 0;
                    int.TryParse(getValueFromDatagridCell(dgProductTransaction, row.Index, QUANTITY_INDEX).ToString(), out old_qty);

                    int return_qty = 0;
                    int.TryParse(txtQty.Text, out return_qty);

                    int new_qty = old_qty;
                    if (return_qty <= old_qty)
                        new_qty = old_qty - return_qty;
                    else
                        MessageBox.Show("Value cannot be higher than the sold qyt");

                    dgProductTransaction.SelectedRows[0].Cells[QUANTITY_INDEX].Value = new_qty;

                    decimal unit_price = (decimal)getValueFromDatagridCell(dgProductTransaction, row.Index, UNIT_PRICE_INDEX);
                    decimal new_group_price = unit_price * new_qty;
                    dgProductTransaction.SelectedRows[0].Cells[GROUP_PRICE_INDEX].Value = new_group_price;

                    computeTotalPrice();

                    // TODO
                    Product product = dbController.getProductThroughName(desc);
                    ProductReturned productReturned = new ProductReturned(int.Parse(txtTransactionno.Text), return_qty, DateTime.Now, inputDialog.prompt, product.Barcode);
                    ProductReturnMapper prm = new ProductReturnMapper(dbController.mySqlDB);
                    prm.insertProductReturn(productReturned);

                    updateProductTransaction(desc, parseTransactionNo(), return_qty, new_group_price);
                    dbController.updateTotalPrice(parseTransactionNo().ToString(), new_group_price);
                }

                txtQty.Clear();
                searchTransaction();   
            }
        }

        void printReceipt()
        {
            PaperSize size = new PaperSize("receipt", 300, 700);

            PrinterSettings printerSettings = new PrinterSettings()
            {
                // FILLME
            };

            PageSettings setting = new PageSettings()
            {
                PaperSize = size
            };

            PrintDocument receipt = new PrintDocument();
            receipt.PrintPage += receipt_PrintPage;
            receipt.DefaultPageSettings = setting;
            PrintPreviewDialog preview = new PrintPreviewDialog()
            {
                Height = 600,
                Document = receipt,

            };

            preview.ShowDialog(this);
            preview.SetDesktopLocation(masterController.getFrmMain.Width - preview.Width, preview.DesktopLocation.Y);
        }

        void receipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Font font = new Font("MS San Serif", 11, FontStyle.Regular))
            using (Pen pen = new Pen(Brushes.Black, 1))
            {
                string title = "Exogenesis";
                string addressL1 = "2/F Nova Square Shopping Center,";
                string addressL2 = "San Bartolome, Nova. QC";
                int documentWidth = e.PageBounds.Width;

                int Y = 20;
                int yIncrement = 5;

                SizeF stringSize = g.MeasureString(title, font);
                g.DrawString(title, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(addressL1, font);
                g.DrawString(addressL1, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;
                stringSize = g.MeasureString(addressL2, font);
                g.DrawString(addressL2, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;


                g.DrawLine(pen, new Point(10, Y), new Point(documentWidth - 10, Y));
                Y += yIncrement;

                string productheader = "** PRODUCTS **";
                stringSize = g.MeasureString(productheader, font);
                g.DrawString(productheader, font, Brushes.Black, new PointF(10, Y));
                Y += (int)stringSize.Height + yIncrement;

                foreach (DataGridViewRow row in dgProductTransaction.Rows)
                {
                    const int DESC_INDEX = 0;
                    const int QUANTITY_INDEX = 2;
                    const int GROUP_PRICE_INDEX = 3;

                    string desc = row.Cells[DESC_INDEX].Value.ToString();
                    string qty = row.Cells[QUANTITY_INDEX].Value.ToString();
                    string grp_price = row.Cells[GROUP_PRICE_INDEX].Value.ToString();

                    string cart = String.Format("{0} ({1})", desc, qty);
                    g.DrawString(cart, font, Brushes.Black, new PointF(10, Y));

                    stringSize = g.MeasureString(grp_price, font);
                    g.DrawString(grp_price, font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));

                    Y += (int)stringSize.Height + yIncrement;

                }

                Y += 20;
                string total = lblAmount.Text;
                g.DrawString("TOTAL", font, Brushes.Black, new PointF(10, Y));
                stringSize = g.MeasureString(total, font);
                g.DrawString(total, font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));
                Y += (int)stringSize.Height + yIncrement;

                string countItems = String.Format("** {0} item(s) **", dgProductTransaction.Rows.Count);
                stringSize = g.MeasureString(countItems, font);
                g.DrawString(countItems, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                string orderNo = String.Format("ORDER #{0}", txtTransactionno.Text);
                g.DrawString(orderNo, font, Brushes.Black, new PointF(10, Y));
                Y += 30;

                g.DrawLine(pen, new Point(10, Y), new Point(documentWidth - 10, Y));
                Y += yIncrement;

                string cashierName = string.Format("Cashier name: {0}", masterController.LoginEmployee.User_id);
                g.DrawString(cashierName, font, Brushes.Black, new PointF(10, Y));
                Y += 30;

                g.DrawString(DateTime.Now.ToString(), font, Brushes.Black, new PointF(10, Y));
                Y += 30;
                g.DrawString("- THIS IS YOUR OFFICIAL RECEIPT -", font, Brushes.Black, new PointF(10, Y));

            }
            resetTransaction();
        }

        void resetTransaction()
        {
            lblAmount.ResetText();
            txtTransactionno.Text = "0";
            txtQty.Clear();

            txtTransactionno.Enabled = false;
            txtQty.Enabled = false;
            searchTransaction();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fillgdInventory();
        }

        private void txtTransactionno_TextChanged(object sender, EventArgs e)
        {
            string charAllowed = "PV-1234567890";
            MyExtension.Validation.limitTextbox(txtTransactionno, charAllowed);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            string charAllowed = "1234567890";
            MyExtension.Validation.limitTextbox(txtQty, charAllowed);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dgInventory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productSliderPane1.mode = InventoryMode.UPDATE;

            if (!productSliderPane1.isOpen())
                productSliderPane1.toggle();

            updateProduct();
        }

        private void dgInventory_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Product product = dbController.productMapper.getProductFromName(getValueFromDatagridCell(PRODUCT_NAME_INDEX));
            toolTip1.BackColor = Color.Green;
            toolTip1.ForeColor = Color.White;
            Rectangle cellRectangle = dgInventory.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

            toolTip1.Show(product.Barcode, 
                this, 
                cellRectangle.Left + dbController.masterController.getFrmMain.Left + panel4.Left + dgInventory.Left,
                cellRectangle.Bottom + panel4.Top + (cellRectangle.Height * 2)
                );
        }
        /// <summary>
        /// Get Barcode from current selected row
        /// </summary>
        /// <returns>string - barcode</returns>
        private string getBarcodeFromRow()
        {
            string product_name = getValueFromDatagridCell(PRODUCT_NAME_INDEX);
            string product_description = getValueFromDatagridCell(PRODUCT_DESCRIPTION_INDEX);
            Product product = dbController.productMapper.getProductFromNameAndDesc(product_name, product_description);
            return product.Barcode;
        }

        private void filterNames(object sender, EventArgs e)
        {
            Validation.filterToNames(sender as TextBox);
        }

        private void filterContacts(object sender, EventArgs e)
        {
            Validation.filterToContactNo(sender as TextBox);
        }

        private void filterEmail(object sender, EventArgs e)
        {
            Validation.filterToEmail(sender as TextBox);
        }

        private void filterParagraph(object sender, EventArgs e)
        {
            Validation.filterToParagraph(sender as TextBox);
        }

        private void filterAlphaNumeric(object sender, EventArgs e)
        {
            search(txtSearch.Text);
            Validation.filterToAlphaNumeric(sender as TextBox);
        }

        private void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.Text == "ALL")
                fillgdInventory();
            else
                filterdgInventory(cbCategory.Text, true);
        }

        private void keyButton6_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }

}

