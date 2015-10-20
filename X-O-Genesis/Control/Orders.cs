using System;
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

namespace PetvetPOS_Inventory_System
{
    public partial class Orders : MyUserControl, IContentPage, IKeyController
    {
        Invoice currentTransaction;
        DatabaseController dbController;
        Product currentProduct;
        DataTable dt = new DataTable();
        List<ProductInvoice> carts = new List<ProductInvoice>();

        bool concludeTransaction;
        decimal totalAmount;
        decimal totalAmountWithService;
        decimal change;

        private const int QTY_INDEX = 0;
        private const int DESCRIPTION_INDEX = 1;
        private const int PRICE_INDEX = 2;

      void computeTotalAmountWithService()
        {
            decimal servicesSubtotal = 0M;
            foreach (AddServices services in addServices)
                servicesSubtotal += services.Subtotal;

            totalAmountWithService = totalAmount + servicesSubtotal;
            poSlbl2.Text = string.Format("{0:0.00}", totalAmountWithService);
        }
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

        public Orders()
        {
            InitializeComponent();
            initTable();
        }
   
        public Orders(MasterController masterController):base(masterController)
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

                activateServices(true);
            }
            else
            {
                txtEncode.Focus();
            }
        }
        public bool queryProduct()
        {
            bool success = false;
            string barcode = txtEncode.Text;
            int quantity = 1;

            if(string.IsNullOrWhiteSpace(txtQuantity.Text))
                MessageBox.Show("Please enter quantity");
            else
                quantity = int.Parse(txtQuantity.Text);

            currentProduct = dbController.getProductFromBarcode(barcode);

            if (!string.IsNullOrWhiteSpace(currentProduct.Barcode)){
                Decimal totalPrice = currentProduct.UnitPrice * quantity;
                lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, quantity, totalPrice);
                success = true;
                addRowInDatagrid(quantity);
            }
            else{
                lblPOSmsg.Text = "Item not found";
            }

            return success;
        }

        public void addRowInDatagrid(int quantity)
        {
           
            ProductInvoice productTransaction = new ProductInvoice(){
                invoice = currentTransaction,
                product = currentProduct,
                QuantitySold = quantity,
                GroupPrice = (currentProduct.UnitPrice * quantity),
            };

            bool items_already_in_cart = false;
            int sum_of_qty = 0;
            decimal sum_of_price = 0M;

            foreach (ProductInvoice item in carts){
                if (item.product.Barcode == productTransaction.product.Barcode){
                    int old_qty = item.QuantitySold;
                    int new_qty = productTransaction.QuantitySold;
                    sum_of_qty = old_qty + new_qty;
                    item.QuantitySold = sum_of_qty;

                    decimal old_price = item.GroupPrice;
                    decimal new_price = productTransaction.GroupPrice;
                    sum_of_price = old_price + new_price;
                    item.GroupPrice = sum_of_price;

                    items_already_in_cart = true;
                    break;
                }
            }

            if (!items_already_in_cart){
                carts.Add(productTransaction);
                try{
                    var row = dt.NewRow();
                    row["Product"] = currentProduct.Description;
                    row["Quantity"] = quantity;
                    row["Price"] = productTransaction.GroupPrice;
                    dt.Rows.Add(row);
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                }
                lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, quantity, productTransaction.GroupPrice);
            }
            else{
                try{
                    foreach (DataGridViewRow row in dgTransaction.Rows){
                        if (row.Cells[DESCRIPTION_INDEX].Value.ToString() == productTransaction.product.Description){
                            row.Cells[QTY_INDEX].Value = sum_of_qty;
                            row.Cells[PRICE_INDEX].Value = sum_of_price;
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
                lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, sum_of_qty, sum_of_price);
            }
            
            totalAmount += productTransaction.GroupPrice;
            poSlbl2.Text = totalAmount.ToString();
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
        }

        private void txtEncode_TextChanged(object sender, EventArgs e)
        {
            string acceptedChar = "1234567890";
            MyExtension.Validation.limitTextbox(sender as TextBox, acceptedChar);
        }

        //private void barcodeIndicator_Tick(object sender, EventArgs e)
        //{
        //    rightSidePane.BackgroundImage = Properties.Resources.barcodeWhite;
        //    barcodeIndicator.Stop();
        //}

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

            //lblChange.ResetText();
            carts.Clear();
            clearDataGrid();
            resetServices();

            concludeTransaction = false;
            poSlbl2.Text = "0";
            lblPOSmsg.Text = "No current transaction";
        }

        private void settle()
        {
            if (dgTransaction.Rows.Count > 0)
            {
                concludeTransaction = true;
                printInvoice();             
                conclusion();
                resetTransaction();
            }
        }

        void conclusion()
        {
            // End the transaction
            concludeTransaction = true;
            toggleEncoding(false);

            Inventory inventory = null;
            foreach (ProductInvoice item in carts){
                dbController.insertProductInvoice(item);
                inventory = new Inventory(){
                    Barcode = item.product.Barcode,
                    QtyReceived = 0,
                    QtyOnHand = -item.QuantitySold,
                };
                  dbController.pullInventory(inventory);
                  dbController.checkProductCriticalLevel(item.product);
        	}

            // audit 
            string message = string.Format("completed a transaction: {0}", lblTransactionno.Text);
            dbController.insertAuditTrail(message);
            masterController.clientClock();
        }

        //private void paymentTimer_Tick(object sender, EventArgs e)
        //{
        //    lblPOSmsg.Text = String.Format("Change: Php {0}", change);
        //    paymentTimer.Stop();
        //}

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
                        if (item.product.Description == selectedRow.Cells[DESCRIPTION_INDEX].Value.ToString())
                        {
                            totalAmount -= item.GroupPrice;
                            carts.Remove(item);

                            if (totalAmountWithService != 0)
                                poSlbl2.Text = totalAmountWithService.ToString();
                            else
                                poSlbl2.Text = totalAmount.ToString();

                            lblPOSmsg.Text = string.Format("Void {0}", item.product.Description);
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

        void invoice_Layout(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            using(Font font = new Font("MS San Serif", 11, FontStyle.Regular))
            using (Pen pen = new Pen(Brushes.Black, 1))
            {
                string title = "Company Name";
                string addressL1 = "Company Address Line 1";
                string addressL2 = "Company Address Line 2";
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

                Bitmap bmp = new Bitmap(this.dgTransaction.Width, this.dgTransaction.Height);
                dgTransaction.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgTransaction.Width, this.dgTransaction.Height));
                g.DrawImage(bmp, new PointF(10, Y));
                Y += 50;

                string serviceheader = "** SERVICES **";
                stringSize = g.MeasureString(serviceheader, font);
                g.DrawString(serviceheader, font, Brushes.Black, new PointF(10, Y));
                Y += (int)stringSize.Height + yIncrement;

               
                string cashierName = string.Format("Cashier name: {0}", masterController.LoginEmployee.User_id);
                g.DrawString(cashierName, font, Brushes.Black, new PointF(10, Y));
                Y += 30;

                  

                
            }
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (sidePanel.Width <= 10)
        //        timer1.Stop();
        //    sidePanel.Size = new Size(sidePanel.Width - 10, sidePanel.Height);

        //}

        
        // Services Fields
        private const int ADDSERVICES_HEIGHT = 100;
        private const int INITIAL_Y = 70;
        private const int MARGIN = 20;
        private const int LINE_HEIGHT = 10;

        List<AddServices> addServices = new List<AddServices>();
        int Y = INITIAL_Y;

 
        void addService_SubTotalCompute(object sender, EventArgs e)
        {
            AddServices addService = sender as AddServices;
            lblPOSmsg.Text = string.Format("{0} x{1} @{2}", addService.getServiceNameSize(),
                addService.Qty, addService.Subtotal);

            computeTotalAmountWithService();
        }

        void updateY()
        {
            Y = INITIAL_Y + (addServices.Count * (ADDSERVICES_HEIGHT + LINE_HEIGHT));
        }

        int computeForY(int index)
        {
            return Y = INITIAL_Y + ((index - 1) * (ADDSERVICES_HEIGHT + LINE_HEIGHT));
        }

        void addService_paneClose(object sender, EventArgs e)
        {
            AddServices a = sender as AddServices;
            int index = 0;

            if (addServices.Contains(a))
                index = addServices.IndexOf(a);

            int length = addServices.Count;
            Point previousLocation = Point.Empty;
            for (int i = 0; i < length; i++){
                if (i > index){
                    addServices[i].NewLocation = new Point(addServices[i].Location.X, computeForY(i));
                }
            }

            addServices.RemoveAt(index);
            computeTotalAmountWithService();
            updateY();
        }

        
        private void txtQuantity_EnabledChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Enabled)
            {
                txtQuantity.Focus();
                btnQuantity.Enabled = true;
                masterController.setFormReturnkey = btnQuantity;
            }
            else
            {
                btnQuantity.Enabled = false;
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

        //private void txtPayment_Enter(object sender, EventArgs e)
        //{
        //    masterController.setFormReturnkey = btnPayment;
        //}

        int btn_click_counter = 0;

        //private void btnPayment_Click(object sender, EventArgs e)
        //{
        //    swithClickIndicator(++btn_click_counter);

        //    if (btn_click_counter == 2){
        //        decimal payment = 0;
        //        if (string.IsNullOrWhiteSpace(txtPayment.Text))
        //            MessageBox.Show("Enter payment");
        //        else
        //            payment = decimal.Parse(txtPayment.Text);
        //        pay(payment);
        //        swithClickIndicator(btn_click_counter = 0);
        //    }
        //}

        //void swithClickIndicator(int numberOfClicks)
        //{
        //    switch (numberOfClicks)
        //    {
        //        case 0:
        //            clickIndicator1.BackColor = Color.White;
        //            clickIndicator2.BackColor = Color.White;
        //            break;
        //        case 1:
        //            clickIndicator1.BackColor = SystemColors.subHeaderGreen;
        //            break;
        //        case 2:
        //            clickIndicator2.BackColor = SystemColors.subHeaderGreen;
        //            break;
        //    }
        //}

        private void textChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string charAllowed = "1234567890.";
            MyExtension.Validation.limitTextbox(textBox, charAllowed);
        }


        //private void txtPayment_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (txtPayment.Enabled)
        //        btnPayment.Enabled = true;
        //    else
        //        btnPayment.Enabled = false;
        //}

        void activateServices(bool flag)
        {
            foreach (AddServices item in addServices)
                item.activate(flag);
        }

        void resetServices()
        {
            if (addServices.Count > 1)
            {
                int length = addServices.Count;
                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                        addServices[i].reset();
                    else
                        addServices[i].Exit();
                }
            }

            foreach (AddServices item in addServices)
                item.reset();
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

        //Events not triggered
        private void keyButton1_Click(object sender, EventArgs e)
        {
            toggleEncoding(true);
        }

        //private void txtPayment_TextChanged(object sender, EventArgs e)
        //{
        //    string charAllowed = "1234567890.";
        //    MyExtension.Validation.limitTextbox(txtPayment, charAllowed);
        //}
    }
}
