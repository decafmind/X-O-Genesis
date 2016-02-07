using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading;
using MyExtension;

namespace PetvetPOS_Inventory_System
{
    public partial class POS : MyUserControl, IContentPage, IKeyController
    {
        Invoice currentTransaction;
        Product currentProduct;
        DataTable dt = new DataTable();
        List<ProductInvoice> carts = new List<ProductInvoice>();

        bool concludeTransaction;
        decimal totalAmount;
        decimal totalAmountWithService;
        decimal change;
       
        private const int QTY_INDEX = 1;
        private const int DESCRIPTION_INDEX = 0;
        private const int PRICE_INDEX = 2;

        void POS_KeyFunction(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1){
                toggleEncoding(true);
                keyButton1.updateButton();
            }
            else if (e.KeyCode == Keys.F2){
                txtPayment.Focus();
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

        public POS()
        {
            InitializeComponent();
        }
   
        public POS(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
            initTable();
        }

        
        private void POS_Load(object sender, EventArgs e)
        {
   
        }

        private void txtEncode_Enter(object sender, EventArgs e) {
            masterController.setFormReturnkey = btnEncode;
        }
        private void txtEncode_EnabledChanged(object sender, EventArgs e)
        {

            if (txtEncode.Enabled)
                btnEncode.Enabled = true;
            else
                btnEncode.Enabled = false;
        }

        public void toggleEncoding()
        {
            if (txtEncode.Enabled){
                toggleEncoding(false);
            }
            else{
                toggleEncoding(true);
            }
        }

        public void toggleEncoding(bool flag)
        {
            txtEncode.Enabled = flag;
            txtName.Enabled = flag;
            txtAddress.Enabled = flag;

            if (flag){
                txtEncode.Clear();
                txtName.Clear();
                txtAddress.Clear();
                beginTransaction();
            }
        }

        // This methods activate the querying of product
        private void btnEncode_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtEncode.Text)))
                return;

            // The minimum character of a barcode should be 8 (EAN-8)
            // And max of 13 (EAN-13)
            if (txtEncode.Enabled){
                if (queryProducts()){
                    barcodeIndicator.Start();
                }
                else{
                    txtEncode.Clear();
                }
            }
        }

        public void initializePage()
        {
            if (txtEncode.Enabled)
                txtEncode.Focus();
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            toggleEncoding();
        }

        public Menu accessMenuName
        {
            get { return Menu.POS; }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.cashRegister; }
        }

        public KeyFunction getKeyController
        {
            get { return new KeyFunction(POS_KeyFunction); }
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
                totalAmount = 0M;
            }
            else
            {
                txtEncode.Focus();
            }
        }

        
        public bool queryProducts()
        {
            bool success = false;
            int invoice_no = 0;
            int sum_of_qty = 0;
            decimal sum_of_price = 0M;

            if (int.TryParse(txtEncode.Text, out invoice_no))
            {
                Invoice invoice = new Invoice() { InvoiceId = invoice_no };

                ProductInvoice pI = new ProductInvoice() { invoice = invoice };
                if (!dbController.checkIfAlreadyConsumed(pI))
                {
                    lblPOSmsg.Text = "PV-" + invoice.InvoiceId.ToString("00000");
                    carts = dbController.getListOfProductInvoice(invoice);
                    int quantity = carts.Count;
                    dt.Clear();

                    foreach (ProductInvoice productInvoice in carts)
                    {
                        currentProduct = dbController.getProductFromBarcode(productInvoice.product.Barcode);
                        sum_of_qty += productInvoice.QuantitySold;
                        sum_of_price += productInvoice.GroupPrice;
                        addRowInDatagrid(productInvoice);
                    }

                    poSlbl2.Text = sum_of_price.ToString("N");
                    totalAmount = sum_of_price;
                    success = true;
                }
                else
                {
                    MessageBox.Show("Invoice transaction was already used or do not exist.");
                }
            }
            txtEncode.Clear();
            return success;
        }

        public void addRowInDatagrid(ProductInvoice productInvoice)
        {
            var row = dt.NewRow();
            row["Product"] = currentProduct.Name;
            row["Quantity"] = productInvoice.QuantitySold;
            row["Unit price"] = currentProduct.UnitPrice.ToString("N");
            row["Net price"] = productInvoice.GroupPrice.ToString("N");
            dt.Rows.Add(row);
        }

        void initTable()
        {
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Quantity", typeof(Int32));
            dt.Columns.Add("Unit price", typeof(string));
            dt.Columns.Add("Net Price", typeof(string));
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

        private void barcodeIndicator_Tick(object sender, EventArgs e)
        {
            barcodeIndicator.Stop();
        }

        void resetTransaction()
        {
            if (!concludeTransaction){
                DialogResult result = MessageBox.Show("It's seems there are still unfinished transaction. Are you sure you want to reset?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                    return;
            }

            currentTransaction = null;
            toggleEncoding(true);

            lblChange.ResetText();
            carts.Clear();
            clearDataGrid();

            concludeTransaction = false;
            poSlbl2.Text = "0";
            lblPOSmsg.Text = "No current transaction";
        }

        public void pay(Decimal payment)
        {
            if (payment >= totalAmount)
            {
                decimal total = totalAmount;

                if (dbController.insertReceipt(currentTransaction, total, payment, txtName.Text, txtAddress.Text)){
                    lblPOSmsg.Text = String.Format("Payment: Php {0:N}", payment);
                    change = payment - total;
                    lblChange.Text = change.ToString("N");

                    concludeTransaction = true;
                    conclusion();
                    paymentTimer.Start();
                    printReceipt();
                    txtPayment.Clear();
                    resetTransaction();
                }
            }
            else
            {
                MessageBox.Show("Oops.. Insuficient payment");
            }
        }

        void conclusion()
        {
            // End the transaction
            concludeTransaction = true;
            toggleEncoding(false);

            Inventory inventory = null;
            foreach (ProductInvoice item in carts){
                inventory = new Inventory(){
                    Barcode = item.product.Barcode,
                    QtyReceived = 0,
                    QtyOnHand = -item.QuantitySold,
                };
                Product product = dbController.getProductFromBarcode(item.product.Barcode);
                dbController.pullInventory(inventory);
                dbController.checkProductCriticalLevel(product);
                dbController.consumeProductInvoice(item);
        	}

            // audit 
            string message = string.Format("completed a transaction: {0}", lblPOSmsg.Text);
            dbController.insertAuditTrail(message);
            masterController.clientClock();
        }

        private void paymentTimer_Tick(object sender, EventArgs e)
        {
            lblPOSmsg.Text = String.Format("Change: Php {0}", change.ToString("N"));
            paymentTimer.Stop();
        }

        void clearDataGrid()
        {
            dt.Rows.Clear();
            dgTransaction.DataSource = dt;
        }

        void printReceipt()
        {
            if (concludeTransaction){
                PaperSize size = new PaperSize("receipt", 300, 700);
               
                PrinterSettings printerSettings = new PrinterSettings(){
                    // FILLME
                };
                
                PageSettings setting = new PageSettings(){
                    PaperSize = size
                };

                PrintDocument receipt = new PrintDocument();
                receipt.PrintPage += receipt_PrintPage;
                receipt.DefaultPageSettings = setting;
                PrintPreviewDialog preview = new PrintPreviewDialog(){
                    Width = 300,
                    Height = 700,
                    Document = receipt,
                };

                receipt.Print();
                //preview.ShowDialog(this);
                //preview.SetDesktopLocation(masterController.getFrmMain.Width - preview.Width, preview.DesktopLocation.Y);
            }
        }

        modalVoid modalFrm;

        void voidProduct()
        {
            modalFrm = new modalVoid(dbController);
            modalFrm.btnOK.Click += btnOK_Click;
            modalFrm.Show();
        }


        void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = modalFrm.getResult;
                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = dgTransaction.SelectedRows[0];
                    foreach (ProductInvoice item in carts)
                    {
                        if (item.product.Name == selectedRow.Cells[DESCRIPTION_INDEX].Value.ToString())
                        {
                            totalAmount -= item.GroupPrice;
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
                    MessageBox.Show("Wrong admin credentials");
                }
            }
            catch (Exception)
            {
                
            }
        }

        
        void receipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            string title = Properties.Settings.Default.CompanyName;
            string tin = " ****-****-****-****";
            string address = Properties.Settings.Default.CompanyAddress;
            string cont = Properties.Settings.Default.CompanyContact;
            string web = Properties.Settings.Default.CompanyEmail;

            Graphics g = e.Graphics;
            using(Font font = new Font("MS San Serif", 11 , FontStyle.Regular))
            using(Pen pen = new Pen(Brushes.Black, 1))
            {

                int documentWidth = e.PageBounds.Width;
                int Y = 20;
                int yIncrement = 5;

                SizeF stringSize = g.MeasureString(title, font);
                g.DrawString(title, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(tin, font);
                g.DrawString(tin, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(address, font);
                g.DrawString(address, font, Brushes.Black, new PointF((documentWidth - stringSize.Width)/2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(cont, font);
                g.DrawString(cont, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                stringSize = g.MeasureString(web, font);
                g.DrawString(web, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                g.DrawLine(pen, new Point(10, Y), new Point(documentWidth - 10, Y));
                Y += yIncrement;

                string productheader = "** PRODUCTS **";
                stringSize = g.MeasureString(productheader, font);
                g.DrawString(productheader, font, Brushes.Black, new PointF(10, Y));
                Y += (int)stringSize.Height + yIncrement;

                foreach (ProductInvoice p in carts)
                {
                    Product product = dbController.getProductFromBarcode(p.product.Barcode);
                    string cart = String.Format("{0} ({1})", product.Name, p.QuantitySold);
                    g.DrawString(cart, font, Brushes.Black, new PointF(10, Y));

                    stringSize = g.MeasureString(p.GroupPrice.ToString(), font);
                    g.DrawString(string.Format("{0:N}",p.GroupPrice), font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));

                    Y += (int)stringSize.Height + yIncrement;

                    stringSize = g.MeasureString(p.product.Barcode, font);
                    g.DrawString(p.product.Barcode, font, Brushes.Black, new PointF(20, Y));

                    Y += (int)stringSize.Height + yIncrement;
                }

                Y += 20;
                string total = poSlbl2.Text;
                g.DrawString("TOTAL", font, Brushes.Black, new PointF(10, Y));
                stringSize = g.MeasureString(total, font);
                g.DrawString(total, font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));
                Y += (int)stringSize.Height + yIncrement;

                g.DrawString("AMOUNT TENDERED", font, Brushes.Black, new PointF(10, Y));
                Y += 30;

                string cash = txtPayment.Text;
                g.DrawString("CASH", font, Brushes.Black, new PointF(10, Y));
                stringSize = g.MeasureString(cash, font);
                g.DrawString(cash, font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));
                Y += (int)stringSize.Height + yIncrement;

                string change = lblChange.Text;
                g.DrawString("CHANGE", font, Brushes.Black, new PointF(10, Y));
                stringSize = g.MeasureString(change, font);
                g.DrawString(change, font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));
                Y += (int)stringSize.Height + yIncrement;

                string countItems = String.Format("** {0} item(s) **", carts.Count);
                stringSize = g.MeasureString(countItems, font);
                g.DrawString(countItems, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + yIncrement;

                string orderNo = String.Format("ORDER # {0} ", txtEncode.Text);
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
        }


        private void txtPayment_Enter(object sender, EventArgs e)
        {
            masterController.setFormReturnkey = btnPayment;
        }

        int btn_click_counter = 0;

        private void btnPayment_Click(object sender, EventArgs e)
        {
            swithClickIndicator(++btn_click_counter);

            if (btn_click_counter == 2){
                decimal payment = 0;
                if (string.IsNullOrWhiteSpace(txtPayment.Text))
                    MessageBox.Show("Enter payment");
                else
                    payment = decimal.Parse(txtPayment.Text);
                pay(payment);
                swithClickIndicator(btn_click_counter = 0);
            }
        }

        void swithClickIndicator(int numberOfClicks)
        {
            switch (numberOfClicks)
            {
                case 0:
                    clickIndicator1.BackColor = Color.White;
                    clickIndicator2.BackColor = Color.White;
                    break;
                case 1:
                    clickIndicator1.BackColor = SystemColors.subHeaderGreen;
                    break;
                case 2:
                    clickIndicator2.BackColor = SystemColors.subHeaderGreen;
                    break;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string charAllowed = "1234567890.";
            MyExtension.Validation.limitTextbox(textBox, charAllowed);
        }


        private void txtPayment_EnabledChanged(object sender, EventArgs e)
        {
            if (txtPayment.Enabled)
                btnPayment.Enabled = true;
            else
                btnPayment.Enabled = false;
        }

         private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            string charAllowed = "1234567890.";
            MyExtension.Validation.limitTextbox(txtPayment, charAllowed);
        }

         private void panel8_Paint(object sender, PaintEventArgs e)
         {

         }

         private void panel6_Paint(object sender, PaintEventArgs e)
         {

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

    }
}
