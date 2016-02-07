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

namespace PetvetPOS_Inventory_System
{
    public partial class OrderPOS : MyUserControl, IContentPage, IKeyController
    {
        Invoice currentTransaction;
        Product currentProduct;
        DataTable dt = new DataTable();
        List<ProductInvoice> carts = new List<ProductInvoice>();

        bool concludeTransaction;
        decimal totalAmount;
        decimal change;
        decimal payment;

        private const int QTY_INDEX = 0;
        private const int DESCRIPTION_INDEX = 1;
        private const int PRICE_INDEX = 2;
        private const int GROUP_PRICE_INDEX = 3;


        public OrderPOS()
        {
            InitializeComponent();
        }

        public OrderPOS(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
            initTable();
        }

        public void initializePage()
        {

        }
        public void finalizePage()
        {

        }

        void OrderPOS_KeyFunction(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                toggleEncoding(true);
                keyButton1.updateButton();
            }
            else if (e.KeyCode == Keys.F2)
            {
                pay();
                keyButton2.updateButton();
            }
            else if (e.KeyCode == Keys.F3)
            {
                resetTransaction();
                keyButton3.updateButton();
            }
            else if (e.KeyCode == Keys.F4)
            {
                keyButton4.updateButton();
                voidProduct();
            }
        }
        public KeyFunction getKeyController
        {
            get { return new KeyFunction(OrderPOS_KeyFunction); }
        }
        public Menu accessMenuName
        {
            get { return Menu.POS; }
        }

        public DatabaseController DatabaseController { set { this.dbController = value; } }

        public Bitmap accessImage
        {
            get { return Properties.Resources.cashRegister; }
        }
        private void dgTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEncode_Enter(object sender, EventArgs e)
        {

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
                        lblPOSmsg.Text = String.Format("{0} x{1} @{2}", currentProduct.Description, quantity, currentProduct.UnitPrice);
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
            catch (Exception) { lblPOSmsg.Text = "Item not found"; }

            return success;
        }

        public void addRowInDatagrid(int quantity)
        {
            bool success = false;

            ProductInvoice productTransaction = new ProductInvoice()
            {
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
                    if (stock >= sum_of_qty)
                    {
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
                            if (stock >= sum_of_qty)
                            {
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

            poSlbl2.Text = totalAmount.ToString("N");
            txtEncode.Clear();
            txtQuantity.Clear();
            txtQuantity.Focus();

        }



        void initTable()
        {
            dt.Columns.Add("Quantity", typeof(Int32));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Unit Price", typeof(Decimal));
            dt.Columns.Add("Sub-Total", typeof(Decimal));
            dgTransaction.DataSource = dt;

            dgTransaction.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgTransaction.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgTransaction.DefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            dgTransaction.DefaultCellStyle.SelectionBackColor = SystemColors.posGray;
        }

        void resetTransaction()
        {
            if (!concludeTransaction)
            {
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

        private void pay()
        {
            payment = 0.0M;
            string customerName = string.Empty, customerAddress = string.Empty;
            if (dgTransaction.Rows.Count > 0)
            {
                modalPayment modalpayment = new modalPayment();
                DialogResult result = modalpayment.ShowDialog();

                if (result == DialogResult.OK)
                {
                    payment = modalpayment.Payment;
                    if (payment >= totalAmount)
                    {
                        decimal total = totalAmount;

                        invoice();

                        if (dbController.insertReceipt(currentTransaction, total, payment, customerName, customerAddress))
                        {
                            lblPOSmsg.Text = String.Format("Payment: Php {0:N}", payment);
                            change = payment - total;

                            concludeTransaction = true;
                            conclusion();
                            paymentTimer.Start();
                            printReceipt();
                            resetTransaction();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Oops.. Insuficient payment");
                    }
                }
            }
        }

        void invoice()
        {
            foreach (ProductInvoice item in carts)
            {
                dbController.insertProductInvoice(item);
                dbController.checkProductCriticalLevel(item.product);
        	}
        }

        void conclusion()
        {
            // End the transaction
            concludeTransaction = true;
            toggleEncoding(false);

            Inventory inventory = null;
            foreach (ProductInvoice item in carts)
            {
                inventory = new Inventory()
                {
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
            string message = string.Format("completed a transaction: {0}", lblTransactionno.Text);
            dbController.insertAuditTrail(message);
            masterController.clientClock();
        }

        void voidProduct()
        {
            DataGridViewRow selectedRow = new DataGridViewRow();
            if (dgTransaction.Rows.Count > 0)
            {
                selectedRow = dgTransaction.SelectedRows[0];
                foreach (ProductInvoice item in carts)
                {
                    if (item.product.Description == selectedRow.Cells[DESCRIPTION_INDEX].Value.ToString())
                    {
                        totalAmount -= item.GroupPrice;
                        carts.Remove(item);

                        poSlbl2.Text = totalAmount.ToString("N");

                        lblPOSmsg.Text = string.Format("Void {0}", item.product.Name);
                        break;
                    }
                }
                dgTransaction.Rows.Remove(selectedRow);
            }
        }

        void clearDataGrid()
        {
            dt.Rows.Clear();
            dgTransaction.DataSource = dt;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtEncode.Text)) || (string.IsNullOrWhiteSpace(txtQuantity.Text)))
                return;

            if (txtEncode.Enabled && txtEncode.TextLength > 7)
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

        void printReceipt()
        {
            if (concludeTransaction)
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
                    Width = 300,
                    Height = 700,
                    Document = receipt,
                };

                receipt.Print();
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
            using (Font font = new Font("MS San Serif", 11, FontStyle.Regular))
            using (Pen pen = new Pen(Brushes.Black, 1))
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
                g.DrawString(address, font, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
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
                    g.DrawString(string.Format("{0:N}", p.GroupPrice), font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));

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

                string cash = payment.ToString("N");
                g.DrawString("CASH", font, Brushes.Black, new PointF(10, Y));
                stringSize = g.MeasureString(cash, font);
                g.DrawString(cash, font, Brushes.Black, new PointF((documentWidth - 10) - stringSize.Width, Y));
                Y += (int)stringSize.Height + yIncrement;

                string change = this.change.ToString("N");
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

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            masterController.setFormReturnkey = btnEncode;
        }

    }
}
