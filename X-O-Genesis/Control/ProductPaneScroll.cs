using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class ProductPaneScroll : ScrollPane
    {
        private InventoryView inventoryView;
        private const DockStyle DOCKSTYLE_TYPE = DockStyle.Top;
        public DatabaseController dbController { get; set; }
        private TextBox[] textboxes;

        private Inventory inventory;
        private Product origProduct, product;
        private bool onupdateMode;

        public ProductPaneScroll()
        {
            InitializeComponent();
        }


        void initUpdate(Product product){
            mapProductToTextfields(product);
            txtQuantity.ReadOnly = true;
            txtBarcode.ReadOnly = true;
            txtDescription.Focus();
        }

        void initInsert()
        {
            txtBarcode.ReadOnly = false;
            txtQuantity.ReadOnly = false;
            txtQuantity.Focus();
            clear();
        }

        void mapProductToTextfields(Product product)
        {
            txtBarcode.Text = product.Barcode;
            txtDescription.Text = product.Description;
            txtPrice.Text = product.UnitPrice.ToString();
            cmbCategory.Text = product.Category;
        }

        public void toggleInsert()
        {
            toggle();
            onupdateMode = false;
        }

        public void toggle(Product product)
        {
            toggle();
            onupdateMode = true;
            this.origProduct = product;
        }

        public override void doWhenVisible()
        {
            base.doWhenVisible();
            masterController.setFormReturnkey = button1;
            loadCategoryList();

            if (onupdateMode)
                initUpdate(origProduct);
            else
                initInsert();
        }

        public void loadCategoryList()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(
                            dbController.getListOfCategory().ToArray()
                            );
        }

        public ProductPaneScroll(InventoryView inventory, Panel panel, MasterController masterController)
            : base(masterController, panel, DOCKSTYLE_TYPE)
        {
            InitializeComponent();
            this.inventoryView = inventory;
            base.maxHeight = 250;
            this.dbController = masterController.DataBaseController;

            textboxes = new TextBox[] {
                txtBarcode,
                txtCompany,
                txtDescription,
                txtPrice,
                txtQuantity,
            };
        }

        void clear()
        {
            foreach (TextBox t in textboxes)
                t.Clear();
        }

        void insertProduct()
        {
            inventory = new Inventory(){
                Barcode = txtBarcode.Text,
                StockinDateTime = DateTime.Now,
                QtyReceived = Convert.ToInt32(txtQuantity.Text),
                QtyOnHand = Convert.ToInt32(txtQuantity.Text),
            };

            if (checkIfProductAlreadyExists(txtBarcode.Text)){
                dbController.insertInventory(inventory);
            }
            else{
                product = new Product(){
                    Barcode = txtBarcode.Text,
                    Description = txtDescription.Text,
                    UnitPrice = Convert.ToDecimal(txtPrice.Text),
                    Category = cmbCategory.Text,
                    Company = txtCompany.Text
                };
                dbController.insertProductInsideInventory(inventory, product);
            }
            
            toggle();
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onupdateMode)
            {
                if (!
                    (string.IsNullOrWhiteSpace(txtDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtCompany.Text) ||
                    string.IsNullOrWhiteSpace(txtBarcode.Text))
                    )
                    updateProduct();
            }
            else
            {
                if (isAllEmpty())
                    return;
                else
                    insertProduct();
            }

        }

        void updateProduct()
        {
            product = new Product()
            {
                Barcode = txtBarcode.Text,
                Description = txtDescription.Text,
                UnitPrice = Convert.ToDecimal(txtPrice.Text),
                Category = cmbCategory.Text,
                Company = txtCompany.Text
            };

           
            dbController.updateProduct(origProduct, product);
            onupdateMode = false;
            txtQuantity.Enabled = true;
            txtBarcode.Enabled = true;

            toggle();
            clear();
        }

        private void textChanged(object sender, EventArgs e)
        {
            string acceptedChar = "";
            TextBox thisTexbox = sender as TextBox;

            if (thisTexbox == txtBarcode || thisTexbox == txtQuantity)
                acceptedChar = "1234567890";
            else if (thisTexbox == txtPrice)
                acceptedChar = "1234567890.";
            else
                acceptedChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890 ";

            MyExtension.Validation.limitTextbox(thisTexbox, acceptedChar);

            if (thisTexbox == txtBarcode && txtBarcode.TextLength > 7)
            {
                if(checkIfProductAlreadyExists(txtBarcode.Text)){
                    txtDescription.Text = product.Description;
                    txtPrice.Text = product.UnitPrice.ToString();
                    cmbCategory.Text = product.Category;
                    txtCompany.Text = product.Company;
                }
            }
        }

        private bool isAllEmpty()
        {
            bool isEmpty = false;
            foreach (TextBox t in textboxes){
                if (String.IsNullOrEmpty(t.Text))
                    isEmpty = true;
            }
            return isEmpty;
        }

        bool checkIfProductAlreadyExists(string barcode)
        {
            product = dbController.getProductFromBarcode(barcode);
            if (!string.IsNullOrEmpty(product.Barcode))
                return true;
            return false;
        }

        public void selectNewlyAddedCategory(string category)
        {
            cmbCategory.Text = category;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            modalAddCategory addCategory = new modalAddCategory(dbController, this);
            addCategory.Show(this);
        }
    }
}
