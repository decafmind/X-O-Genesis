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
    public partial class ProductSliderPane : SliderPane
    {
        private const DockStyle DOCKSTYLE_TYPE = DockStyle.Right;
        public InventoryView inventoryView;
        Inventory inventory;
        public DatabaseController dbController;

        Product oldProduct, product;
        public InventoryMode mode;


        public ProductSliderPane()
        {
            InitializeComponent();
        }

        public ProductSliderPane(InventoryView inventory, Panel panel, MasterController masterController)
            : base(masterController, panel, DOCKSTYLE_TYPE)
        {
            InitializeComponent();
            this.inventoryView = inventory;
            this.dbController = masterController.DataBaseController;
        }

        bool checkIfProductAlreadyExists(string barcode)
        {
            product = dbController.getProductFromBarcode(barcode);
            if (!string.IsNullOrEmpty(product.Barcode))
                return true;
            return false;
        }

        public void insertProduct()
        {
            if (MyExtension.Validation.isFilled(contentPanel))
            {
                inventory = new Inventory()
                {
                    Barcode = txtBarcode.Text,
                    StockinDateTime = DateTime.Now,
                };

                if (checkIfProductAlreadyExists(txtBarcode.Text))
                {
                    dbController.insertInventory(inventory);
                }
                else
                {
                    int category_id = dbController.categoryMapper.getCategoryIndexFromName(cbCategory.Text);
                    product = new Product()
                    {
                        Barcode = txtBarcode.Text,
                        Name = txtName.Text,
                       // UnitPrice = Convert.ToDecimal(txtPrice.Text),
                        Warranty = txtWarranty.Text.ToString(),
                        Replacement = txtReplacement.Text.ToString(),
                        Description = txtDescription.Text,
                        Category_id = category_id,
                    };
                    dbController.insertProductInsideInventory(inventory, product);
                }
                toggle();
            }
            else
            {
             //   MessageBox.Show("Missing field required");
            }
        }

        public void clearTexts()
        {
           // MyExtension.Validation.
            MyExtension.Validation.clearFields(contentPanel);
            cbCategory.Text = "";
            txtBarcode.Enabled = true; // To make sure it is enabled even after update
            loadCategoryList();
        }

        public void mapProductToTextfield(Product product)
        {
            clearTexts();
            try
            {
                txtBarcode.Text = product.Barcode.ToString();
                txtBarcode.Enabled = false;
                txtBarcode.ForeColor = Color.DimGray;
                txtBarcode.BackColor = Color.White;

                txtName.Text = product.Name.ToString();
                
                txtDescription.Text = product.Description.ToString();
                txtReplacement.Text = product.Replacement.ToString();
                txtWarranty.Text = product.Warranty.ToString();

                string category = dbController.categoryMapper.getCategoryNameFromId(product.Category_id);
                cbCategory.Text = category;

                oldProduct = product;

            }catch(Exception){

            }
            
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OK();
        }

        public void OK()
        {
            switch (mode)
            {
                case InventoryMode.ADD:
                    insertProduct();
                    break;
                case InventoryMode.UPDATE:
                    updateProduct();
                    break;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            MyExtension.Validation.limitTextbox(sender as TextBox, "01234567890");
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            TextBox thisTexbox = sender as TextBox;

            if (thisTexbox == txtBarcode && txtBarcode.TextLength > 0)
            {
                if (checkIfProductAlreadyExists(txtBarcode.Text))
                {
                    txtName.Text = product.Name.ToString();
                  
                    txtReplacement.Text = product.Replacement.ToString();
                    txtDescription.Text = product.Description.ToString();
                    txtWarranty.Text = product.Warranty.ToString();
                    cbCategory.Text = dbController.categoryMapper.getCategoryNameFromId(product.Category_id);
                }
                else
                {
                    txtName.Clear();
                    
                    txtDescription.Clear();
                    txtWarranty.Clear();
                    txtReplacement.Clear();
                    cbCategory.Text = string.Empty;
                    cbCategory.Items.Clear();
                }
            }
        }

        void updateProduct()
        {
            if (MyExtension.Validation.isFilled(contentPanel))
            {
                int category_id = dbController.categoryMapper.getCategoryIndexFromName(cbCategory.Text);

                product = new Product()
                {
                    Barcode = txtBarcode.Text,
                    Name = txtName.Text,
                  //  UnitPrice = Convert.ToDecimal(txtPrice.Text),
                    Warranty = txtWarranty.Text,
                    Replacement = txtReplacement.Text,
                    Description = txtDescription.Text,
                    Category_id = category_id,
                };

                dbController.updateProduct(oldProduct, product);
               
                txtBarcode.Enabled = true;

                toggle();
                clearTexts();
            }
        }

        public void toggle(InventoryMode mode)
        {
            base.toggle();
            this.mode = mode;
        }

        private void ProductSliderPane_Load(object sender, EventArgs e)
        {

        }

        public override void doWhenNotVisible()
        {
            base.doWhenNotVisible();
        }

        public override void doWhenVisible()
        {
            base.doWhenVisible();
            loadCategoryList();
        }

        public void loadCategoryList()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(dbController.getListOfCategory().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modalAddCategory categoryModal = new modalAddCategory(dbController, this);
            categoryModal.Show();

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            MyExtension.Validation.limitTextbox(sender as TextBox, ".1234567890");
        }
    }
}
