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
        Product currentProduct;
        Inventory inventory;
        DataTable dt = new DataTable();
        List<ProductInvoice> carts = new List<ProductInvoice>();
        List<Discounts> discounts = new List<Discounts>();
        DiscountList discountListForm;
        public ProductInvoice productTransaction;

        bool concludeTransaction;
        decimal totalAmount;
        decimal totalAmountWithService;

        decimal _vatableSales;
        decimal _vat;
        decimal _scpwd;
        int currentQty = 0;

        private const int QTY_INDEX = 0;
        private const int DESCRIPTION_INDEX = 1;
        private const int PRICE_INDEX = 2;
        private const int GROUP_PRICE_INDEX = 3;

   
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

            if (flag)
            {
                txtEncode.Clear();
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
                currentProduct = dbController.getProductFromBarcode(barcode);
                int quantity = 1;
                int stock = dbController.getCurrentStockCountFromBarCode(currentProduct);
                int maintaining_stock = (int)dbController.productInventory.getMaintainingStocks(currentProduct);

                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                    MessageBox.Show("Please enter quantity");
                else
                {
                    quantity = int.Parse(txtQuantity.Text);
                    
                    if (stock >= (currentQty + quantity))
                    {
                        if (!string.IsNullOrWhiteSpace(currentProduct.Barcode))
                        {
                            decimal totalPrice = currentProduct.UnitPrice * quantity;
                            lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, quantity, currentProduct.UnitPrice);
                            success = true;
                            addRowInDatagrid(quantity);
                            currentQty += quantity;
                        }
                        else
                        {
                            lblPOSmsg.Text = "Item not found";
                        }
                    }
                    else
                    {
                        if (stock == 0)
                        {
                            MessageBox.Show("Out of stock.");
                        }
                        else
                        {
                            MessageBox.Show("Insufficient stock. Only " + stock + " left");
                        }
                    }
                }                                                  

            }
            catch (Exception) { lblPOSmsg.Text = "Item not found";  }
            return success;
        }

        public void updateViewWithDiscount()
        {

        }
        public void addRowInDatagrid(int quantity)
        {
            bool success = false;
            discountListForm = new DiscountList();
            productTransaction = new ProductInvoice(){
                invoice = currentTransaction,
                product = currentProduct,
                QuantitySold = quantity,
                GroupPrice = (currentProduct.UnitPrice * quantity),
                DiscPercent = 0,
                DiscFixed = 0,
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
                    row["Product"] = currentProduct.Name;
                    row["Quantity"] = quantity;
                    row["Sub-Total"] = productTransaction.GroupPrice;
                    row["Unit Price"] = productTransaction.product.UnitPrice;
                    dt.Rows.Add(row);
                    lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Name, quantity, productTransaction.GroupPrice);
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
                        if (row.Cells[DESCRIPTION_INDEX].Value.ToString() == productTransaction.product.Name)
                        {
                            row.Cells[QTY_INDEX].Value = sum_of_qty;
                            int stock = dbController.getCurrentStockCountFromBarCode(currentProduct);
                            if (stock >= sum_of_qty){
                                row.Cells[QTY_INDEX].Value = sum_of_qty;
                                row.Cells[GROUP_PRICE_INDEX].Value = sum_of_price;
                                lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Name, sum_of_qty, sum_of_price);
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

            //totalAmount += productTransaction.GroupPrice;
            if (success)
                totalAmount += productTransaction.GroupPrice;

            //_scpwd = chkSCPWD.Checked ? totalAmount * Convert.ToDecimal(0.20) : 0; ---Fix this

            poSlbl2.Text = totalAmount.ToString("N");
            txtEncode.Clear();
            txtQuantity.Clear();
            txtQuantity.Focus();
         
        }

        void initTable()
        {
            dt.Columns.Add("Quantity", typeof(Int32));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Unit Price", typeof(decimal));
            dt.Columns.Add("Sub-Total", typeof(decimal));
            dgTransaction.DataSource = dt;

            dgTransaction.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgTransaction.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgTransaction.DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            dgTransaction.DefaultCellStyle.SelectionBackColor = SystemColors.posGray;
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
            MyExtension.Validation.clearFields(panel1);
        }

        private void settle()
        {
            if (dgTransaction.Rows.Count > 0)
            {
                concludeTransaction = true;
                discountListForm = new DiscountList(this);
                discountListForm.ShowDialog();
                conclusion();
                printInvoice();
                resetTransaction();
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
                inventory = new Inventory(){
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
                //invoice.Print();
            }
        }

        void voidProduct()
        {
            modalRequireAdmin modalRequireAdmin = new modalRequireAdmin(dbController);
            DialogResult result = modalRequireAdmin.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataGridViewRow selectedRow = new DataGridViewRow();
                if (dgTransaction.Rows.Count > 0)
                {
                    selectedRow = dgTransaction.SelectedRows[0];
                    foreach (ProductInvoice item in carts)
                    {
                        if (item.product.Description == selectedRow.Cells[DESCRIPTION_INDEX].Value.ToString())
                        {
                            totalAmount -= item.GroupPrice - _scpwd;
                            carts.Remove(item);

                            if (totalAmountWithService != 0)
                                poSlbl2.Text = totalAmountWithService.ToString("N");
                            else
                                poSlbl2.Text = totalAmount.ToString("N");

                            lblPOSmsg.Text = string.Format("Void {0}", item.product.Name);
                            break;
                        }
                    }
                    dgTransaction.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Wrong admin credentials.");
                }           
            }

        }

        void invoice_Layout(object sender, PrintPageEventArgs e)
        {
            DataTable companyProfile = new DataTable();
            dbController.loadCompanyProfile(companyProfile);

            string title = "Company Name";
            string tin = " Company VAT Registered TIN";
            string address = "Company Address";
            string cont = "Company Contact Number";
            string web = "Company Email / Website";

            decimal tax = 0;
            
          

            foreach (DataRow dr in companyProfile.Rows)
            {
                title = dr["compname"].ToString();
                address = dr["address"].ToString();
                cont = dr["contactno"].ToString();
                web = dr["email"].ToString();
                tin = dr["vat_reg_tin"].ToString();
                tax = Convert.ToDecimal(dr["tax"]);
            }
     
            _vat = tax * Convert.ToDecimal(poSlbl2.Text);  
            _vatableSales = Convert.ToDecimal(poSlbl2.Text) - _vat;
                      
            Graphics g = e.Graphics;
            using(Font font = new Font("MS San Serif", 11, FontStyle.Regular))
            using (Pen pen = new Pen(Brushes.Black, 1))
            {
                string vatReg = String.Format("VAT Reg. TIN: {0}", tin);            
                string contactNo = String.Format("Contact No.: {0}", cont);
                string webSite = String.Format("Website: {0}", web);

                int documentWidth = e.PageBounds.Width;
 
                SizeF stringSize = g.MeasureString(title, font);

                float XQty = 10;
                float XItemName = ((documentWidth - stringSize.Width) / 3) - 100;
                float XUPrice = ((documentWidth - stringSize.Width) / 2) + 180;
                float XSubTotal = ((documentWidth - stringSize.Width) / 1) - 60;

                int Y = 20;
                int yIncrement = 5;

                g.DrawString(title, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) /2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(vatReg, font);
                g.DrawString(vatReg, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(address, font);
                g.DrawString(address, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(contactNo, font);
                g.DrawString(contactNo, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(webSite, font);
                g.DrawString(webSite, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;
            
                g.DrawLine(pen, new Point(10, Y), new Point(documentWidth - 10, Y));
                Y += yIncrement;

                g.DrawString("- SALES INVOICE -", font, Brushes.Black, new PointF(((documentWidth - stringSize.Width) / 2), Y));
                Y += (int)stringSize.Height + yIncrement;

                string orderNo = String.Format("INVOICE #{0}", lblTransactionno.Text);
                g.DrawString(orderNo, font, Brushes.Black, new PointF(10, Y));
                g.DrawString(DateTime.Now.ToString(), font, Brushes.Black, new PointF(520, Y));
                Y += (int)stringSize.Height + yIncrement + 10;

                string customerName = string.Format("Name:      ________________________________________________");
                string cashierName = string.Format("Cashier name: {0}", masterController.LoginEmployee.User_id);
                g.DrawString(customerName, font, Brushes.Black, new PointF(10, Y));
                g.DrawString(cashierName, font, Brushes.Black, new PointF(520, Y));
                Y += (int)stringSize.Height + yIncrement;

                string add = String.Format("Address: ________________________________________________", lblTransactionno.Text);
                g.DrawString(add, font, Brushes.Black, new PointF(10, Y));
                Y += (int)stringSize.Height + yIncrement + 20;

                string productheaderQty = "| Quantity |";
                string productheaderItemName = "| Item Name |";
                string productheaderUnitPrice = "| Unit Price |";
                string productheaderSub = "| Sub-Total |";
                g.DrawString(productheaderQty, font, Brushes.Black, new PointF(XQty, Y));
                g.DrawString(productheaderItemName, font, Brushes.Black, new PointF(XItemName, Y));
                g.DrawString(productheaderUnitPrice, font, Brushes.Black, new PointF(XUPrice, Y));
                g.DrawString(productheaderSub, font, Brushes.Black, new PointF(XSubTotal, Y));
                Y += (int)stringSize.Height + yIncrement;

                foreach (DataRow dr in dt.Rows)
                {
                    g.DrawString(dr[0].ToString(), font, Brushes.Black, new PointF(XQty, Y));
                    g.DrawString(dr[1].ToString(), font, Brushes.Black, new PointF(XItemName, Y));
                    g.DrawString(dr[2].ToString(), font, Brushes.Black, new PointF(XUPrice, Y));
                    g.DrawString(dr[3].ToString(), font, Brushes.Black, new PointF(XSubTotal, Y));
                    Y += (int)stringSize.Height + yIncrement;
                }

                Y += 50;
                string total = poSlbl2.Text;
                g.DrawString("Total Sales (VAT Inclusive)", font, Brushes.Black, new PointF(XQty, Y));
                stringSize = g.MeasureString(total, font);
                g.DrawString(total, font, Brushes.Black, new PointF(XSubTotal, Y));
                Y += (int)stringSize.Height + yIncrement;

                string ScPwdDiscount = _scpwd.ToString("N");
                g.DrawString("Less: SC/PWD Discount", font, Brushes.Black, new PointF(XQty, Y));
                stringSize = g.MeasureString(ScPwdDiscount, font);
                g.DrawString(ScPwdDiscount, font, Brushes.Black, new PointF(XSubTotal, Y));
                Y += (int)stringSize.Height + yIncrement;

                string vatableSales = _vatableSales.ToString("N");
                g.DrawString("VATable Sales", font, Brushes.Black, new PointF(XQty, Y));
                stringSize = g.MeasureString(vatableSales, font);
                g.DrawString(vatableSales, font, Brushes.Black, new PointF(XSubTotal, Y));
                Y += (int)stringSize.Height + yIncrement;

                string vatAmount = _vat.ToString("N");
                g.DrawString("VAT Amount", font, Brushes.Black, new PointF(XQty, Y));
                stringSize = g.MeasureString(vatAmount, font);
                g.DrawString(vatAmount, font, Brushes.Black, new PointF(XSubTotal, Y));
                Y += (int)stringSize.Height + yIncrement;

                string totalSales = poSlbl2.Text;
                g.DrawString("Total Sales", font, Brushes.Black, new PointF(XQty, Y));
                stringSize = g.MeasureString(totalSales, font);
                g.DrawString(totalSales, font, Brushes.Black, new PointF(XSubTotal, Y));
                Y += (int)stringSize.Height + yIncrement;
                Y += 20;

                string countItems = String.Format("** {0} item(s) **", carts.Count);
                stringSize = g.MeasureString(countItems, font);
                g.DrawString(countItems, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                g.DrawLine(pen, new Point(10, Y), new Point(documentWidth - 10, Y));
                Y += yIncrement;          
                         
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
            if (txtEncode.Enabled && txtEncode.TextLength > 6)
            {
                if (queryProduct())
                {
 
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
        
        private void poSlbl2_Load(object sender, EventArgs e)
        {

        }

        private void dgTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
