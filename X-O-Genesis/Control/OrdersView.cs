using System ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MyExtension;

namespace PetvetPOS_Inventory_System
{
    public partial class OrdersView : MyUserControl, IContentPage, IKeyController
    {
        Invoice currentTransaction;
        DatabaseController dbController;
        Product currentProduct;
        Inventory inventory;
        DataTable dt = new DataTable();
        List<ProductInvoice> carts = new List<ProductInvoice>();

        bool concludeTransaction;
        decimal totalAmount;
        decimal totalAmountWithService;
        string customerName = string.Empty;

        private const int QTY_INDEX = 0;
        private const int DESCRIPTION_INDEX = 1;
        private const int PRICE_INDEX = 2;

   
        void Orders_KeyFunction(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1){
                toggleEncoding(true);
                keyButton1.updateButton();
            }
            else if (e.KeyCode == Keys.F2){ 
                settle();
                keyButton2.updateButton();
            }
            else if (e.KeyCode == Keys.F3){
                resetTransaction();
                keyButton3.updateButton();
            }
            else if (e.KeyCode == Keys.F4){
                keyButton4.updateButton();
                voidProduct();
            }
        }
        public KeyFunction getKeyController
        {
            get { return new KeyFunction(Orders_KeyFunction); }
        }
        public Menu accessMenuName
        {
            get { return Menu.Orders; }
        }

        public DatabaseController DatabaseController { set { this.dbController = value; } }

        public Bitmap accessImage
        {
            get { return Properties.Resources.cashRegister; }
        }

        public OrdersView()
        {
            InitializeComponent();
            initTable();
        }
   
        public OrdersView(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
            initTable();
        }

        private void txtEncode_Enter(object sender, EventArgs e)
        {
            masterController.setFormReturnkey = btnEncode;
        }

        public void toggleEncoding()
        {
            if (txtEncode.Enabled)
            {
                toggleEncoding(false);
            }
            else
            {
                toggleEncoding(true);
            }
        }
        public void toggleEncoding(bool flag)
        {
            txtEncode.Enabled = flag;
            txtQuantity.Enabled = flag;
            txtSearch.Enabled = flag;

            if (flag)
            {
                txtEncode.Clear();
                txtSearch.Clear();
                beginTransaction();
            }
        }
        public void initializePage()
        {

        }
        public void finalizePage()
        {
           
        }

        void beginTransaction()
        {
            if (currentTransaction == null)
            {
                currentTransaction = new Invoice()
                {
                    TransactionDateTime = DateTime.Now,
                    EmployeeId = masterController.LoginEmployee.User_id
                };

                dbController.insertTransaction(currentTransaction);
                currentTransaction.InvoiceId = dbController.getTransactionId(currentTransaction);
                lblTransactionno.Text = "POS_" + currentTransaction.InvoiceId.ToString("00000");
                totalAmount = 0M;
            }
            else
            {
                txtEncode.Focus();
            }
        }

        string barcode;
        public bool queryProduct()
        {
            bool success = false;
            try
            {
                barcode = txtEncode.Text;
                int quantity = 1;

                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                    MessageBox.Show("Please enter quantity");
                else
                    quantity = int.Parse(txtQuantity.Text);

                currentProduct = dbController.getProductFromBarcode(barcode);
                int stock = dbController.getCurrentStockCountFromBarCode(currentProduct);
                if (stock >= quantity)
                {
                    if (!string.IsNullOrWhiteSpace(currentProduct.Barcode))
                    {
                        Decimal totalPrice = currentProduct.UnitPrice * quantity;
                    lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, quantity, totalPrice);
                        success = true;
                        addRowInDatagrid(quantity);
                    }
                    else
                    {
                        lblPOSmsg.Text = "Item not found";
                    }
                }
                else
                {
                    MessageBox.Show("Out of stock. Only " + stock + " left");
                }

            }
            catch (Exception) { lblPOSmsg.Text = "Item not found";  }

            return success;
        }

        private void populateCustomerViewDG()
        {
            lblName.Text = string.Empty;
            DataTable dt = new DataTable();
            dbController.getCustomersForOrdering(dt);
            if (dt.Rows.Count > 0)
            {
                dgName.DataSource = dt;
            }           
        }

        public void addRowInDatagrid(int quantity)
        {
            bool success = false;

            ProductInvoice productTransaction = new ProductInvoice(){
                invoice = currentTransaction,
                product = currentProduct,
                QuantitySold = quantity,
                GroupPrice = (currentProduct.UnitPrice * quantity),
            };

            bool items_already_in_cart = false;
            int sum_of_qty = 0;
            decimal sum_of_price = 0M;

            foreach (ProductInvoice item in carts)
            {
                if (item.product.Barcode == productTransaction.product.Barcode)
                {
                    int old_qty = item.QuantitySold;
                    int new_qty = productTransaction.QuantitySold;
                    sum_of_qty = old_qty + new_qty;
                    item.QuantitySold = sum_of_qty;

                    decimal old_price = item.GroupPrice;
                    decimal new_price = productTransaction.GroupPrice;
                    sum_of_price = old_price + new_price;

                    int stock = dbController.getCurrentStockCountFromBarCode(currentProduct);
                    if (stock >= sum_of_qty){
                        item.GroupPrice = sum_of_price;
                        success = true;
                    }
                    items_already_in_cart = true;
                    break;
                }
            }

            if (!items_already_in_cart)
            {
                carts.Add(productTransaction);
                try
                {
                    var row = dt.NewRow();
                    row["Product"] = currentProduct.Description;
                    row["Quantity"] = quantity;
                    row["Price"] = productTransaction.GroupPrice;
                    dt.Rows.Add(row);
                    lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, quantity, productTransaction.GroupPrice);
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in dgTransaction.Rows)
                    {
                        if (row.Cells[DESCRIPTION_INDEX].Value.ToString() == productTransaction.product.Description)
                        {
                            row.Cells[QTY_INDEX].Value = sum_of_qty;
                            row.Cells[PRICE_INDEX].Value = sum_of_price;
                            int stock = dbController.getCurrentStockCountFromBarCode(currentProduct);
                            if (stock >= sum_of_qty){
                                row.Cells[QTY_INDEX].Value = sum_of_qty;
                                row.Cells[PRICE_INDEX].Value = sum_of_price;
                                lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, sum_of_qty, sum_of_price);
                                success = true;
                            }
                            else
                            {
                                MessageBox.Show("Out of stock! " + stock + " left.");
                            }
                            break;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }

            totalAmount += productTransaction.GroupPrice;
            if (success)
                totalAmount += productTransaction.GroupPrice;

            poSlbl2.Text = totalAmount.ToString("N");
            txtEncode.Clear();
            txtQuantity.Clear();
            txtQuantity.Focus();
         
        }

        void initTable()
        {
            dt.Columns.Add("Quantity", typeof(Int32));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Price", typeof(Decimal));
            dgTransaction.DataSource = dt;

            dgTransaction.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgTransaction.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgTransaction.DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            dgTransaction.DefaultCellStyle.SelectionBackColor = SystemColors.posGray;

            populateCustomerViewDG();
        }

        private void txtEncode_TextChanged(object sender, EventArgs e)
        {
            string acceptedChar = "1234567890";
            MyExtension.Validation.limitTextbox(sender as TextBox, acceptedChar);
        }

        void resetTransaction()
        {
            if (!concludeTransaction){
                DialogResult result = MessageBox.Show("It's seems there are still unfinished transaction. Are you sure you want to reset?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                    return;
            }

            currentTransaction = null;
            lblTransactionno.ResetText();
            toggleEncoding(true);

            carts.Clear();
            clearDataGrid();

            concludeTransaction = false;
            txtQuantity.Text = "1";
            poSlbl2.Text = "0";
            lblPOSmsg.Text = "No current transaction";
            lblName.Text = string.Empty;
            MyExtension.Validation.clearFields(panel1);
        }

        private void settle()
        {
            if (dgTransaction.Rows.Count > 0)
            {
                concludeTransaction = true;
                if (!string.IsNullOrWhiteSpace(lblName.Text))
                {
                    conclusion();
                    printInvoice();
                    resetTransaction();
                }
                else
                {
                    MessageBanner banner = new MessageBanner("Please select a customer.", 2000);
                    banner.BackColor = Color.Yellow;
                    banner.Opacity = 1;
                    banner.Show();
                }                        
            }
        }

        void conclusion()
        {
            // End the transaction
            concludeTransaction = true;
            toggleEncoding(false);
          
            inventory = null;
            foreach (ProductInvoice item in carts)
            {
                dbController.insertProductInvoice(item);
                inventory = new Inventory()
                {
                    Barcode = item.product.Barcode,
                    QtyReceived = 0,
                    QtyOnHand = -item.QuantitySold,
                };

                dbController.checkProductCriticalLevel(item.product);
            }        
                 
            // audit 
            string message = string.Format("completed a transaction: {0}", lblTransactionno.Text);
            dbController.insertAuditTrail(message);
            masterController.clientClock();
        }

        void clearDataGrid()
        {
            dt.Rows.Clear();
            dgTransaction.DataSource = dt;
        }

        void printInvoice()
        {
            if (concludeTransaction){
                PaperSize size = new PaperSize("Sales Invoice", 750, 900);
               
                PrinterSettings printerSettings = new PrinterSettings(){
                    // FILLME
                };
                
                PageSettings setting = new PageSettings(){
                    PaperSize = size
                };

                PrintDocument invoice = new PrintDocument();
                invoice.PrintPage += invoice_Layout;
                invoice.DefaultPageSettings = setting;
                PrintPreviewDialog preview = new PrintPreviewDialog(){
                    Width = 750,
                    Height = 900,
                    Document = invoice,
                };

                preview.ShowDialog(this);
                preview.SetDesktopLocation(masterController.getFrmMain.Width - preview.Width, preview.DesktopLocation.Y);

            }
        }

        void voidProduct()
        {
            DataGridViewRow selectedRow = new DataGridViewRow();
            if (dgTransaction.Rows.Count > 0)
            {
              selectedRow  = dgTransaction.SelectedRows[0];
              foreach (ProductInvoice item in carts)
              {
                  if (item.product.Description == selectedRow.Cells[DESCRIPTION_INDEX].Value.ToString())
                  {
                      totalAmount -= item.GroupPrice;
                      carts.Remove(item);

                      if (totalAmountWithService != 0)
                          poSlbl2.Text = totalAmountWithService.ToString("N");
                      else
                          poSlbl2.Text = totalAmount.ToString("N");

                      lblPOSmsg.Text = string.Format("Void {0}", item.product.Description);
                      break;
                  }
              }
              dgTransaction.Rows.Remove(selectedRow);
            }                               
        }

        void invoice_Layout(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            using(Font font = new Font("MS San Serif", 11, FontStyle.Regular))
            using (Pen pen = new Pen(Brushes.Black, 1))
            {
                string title = "Guardtech";
                string addressL1 = "G44 Abbey Road Bagbag";
                string addressL2 = "Novaliches Quezon City";
                int documentWidth = e.PageBounds.Width;
 
                SizeF stringSize = g.MeasureString(title, font);

                int Y = 20;
                int yIncrement = 5;

                g.DrawString(title, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) /2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(addressL1, font);
                g.DrawString(addressL1, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(addressL2, font);
                g.DrawString(addressL2, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                g.DrawLine(pen, new Point(10, Y), new Point(documentWidth - 10, Y));
                Y += yIncrement;

                g.DrawString("- SALES INVOICE -", font, Brushes.Black, new PointF(((documentWidth - stringSize.Width) / 2) + 30, Y));
                Y += 30;
                string orderNo = String.Format("INVOICE #{0}", lblTransactionno.Text);
                g.DrawString(orderNo, font, Brushes.Black, new PointF(10, Y));
                g.DrawString(DateTime.Now.ToString(), font, Brushes.Black, new PointF(520, Y));
                Y += 50;

                string summary = "** SUMMARY **";
                stringSize = g.MeasureString(summary, font);
                g.DrawString(summary, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += 30;

                string productheader = "** ITEMS **";
                g.DrawString(productheader, font, Brushes.Black, new PointF(30, Y));
                Y += 30;

                Bitmap bmp = new Bitmap(documentWidth, this.dgTransaction.Height);
                dgTransaction.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgTransaction.Width, this.dgTransaction.Height));
                g.DrawImage(bmp, new PointF(10, Y));
                Y += 50;
        
                string cashierName = string.Format("Cashier name: {0}", masterController.LoginEmployee.User_id);
                g.DrawString(cashierName, font, Brushes.Black, new PointF(10, Y));
                Y += 30;                  
            }
        }
        
        
        private void btnQuantity_Click(object sender, EventArgs e)
        {
            txtEncode.Focus();
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            masterController.setFormReturnkey = btnQuantity;
            txtQuantity.Text = "1";
            txtQuantity.SelectAll();
        }


        private void textChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string charAllowed = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnoqprstuvwxyz1234567890.";
            MyExtension.Validation.limitTextbox(textBox, charAllowed);
        }



        private void btnEncode_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtEncode.Text)))
                return;

            // The minimum character of a barcode should be 8 (EAN-8)
            // And max of 13 (EAN-13)
            if (txtEncode.Enabled && txtEncode.TextLength > 7)
            {
                if (queryProduct())
                {
                    //rightSidePane.BackgroundImage = Properties.Resources.barcodeBlack;
                    //barcodeIndicator.Start();
                }
                else
                {
                    txtEncode.Clear();
                }
            }
        }

        private void txtEncode_EnabledChanged(object sender, EventArgs e)
        {

            if (txtEncode.Enabled)
                btnEncode.Enabled = true;
            else
                btnEncode.Enabled = false;
        }

        private void keyButton1_Click(object sender, EventArgs e)
        {
            toggleEncoding(true);
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
        private void filterAplhaNumeric(object sender, EventArgs e)
        {
            Validation.filterToAlphaNumeric(sender as TextBox);
        }
        private void filterNumeric(object sender, EventArgs e)
        {
            Validation.filterToNumeric(sender as TextBox);
        }
        private void dgName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getValueFromDataGridCell();
            if (!string.IsNullOrEmpty(customerName))
                lblName.Text = customerName;
        }

        private void getValueFromDataGridCell()
        {
            const int NAME = 0;

            if (dgName.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgName.SelectedRows[0];
                customerName = getValueFromDataGridCell(dgName, row.Index, NAME).ToString();          
            }

        }
        object getValueFromDataGridCell(DataGridView gv, int row_index, int cell_index)
        {
            return gv.Rows[row_index].Cells[cell_index].Value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getCustomersForOrderingByName(txtSearch.Text);
        }
        private void getCustomersForOrderingByName(string name)
        {
            DataTable dt = new DataTable();
            dbController.getCustomersForOrderingByName(dt, name);
            if (dt.Rows.Count > 0)
            {
                dgName.DataSource = dt;
            }          
        }

    }
}
