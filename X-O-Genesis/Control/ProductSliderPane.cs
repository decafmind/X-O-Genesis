using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyExtension;

namespace PetvetPOS_Inventory_System
{
    public partial class ProductSliderPane : SliderPane
    {
        private const DockStyle DOCKSTYLE_TYPE = DockStyle.Right;
        public InventoryView inventoryView;
        Inventory inventory;

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
            bool existingProduct = checkIfProductAlreadyExists(txtBarcode.Text);
            ProductInventoryDomain productInventoryDomain;
            modalAddStocks addStocks = null;

            if (existingProduct)
            {
                productInventoryDomain = dbController.productInventory.getProductInventoryThroughBarcode(txtBarcode.Text);
                addStocks = new modalAddStocks(productInventoryDomain.product.Barcode,
                                                        productInventoryDomain.product.Name,
                                                        productInventoryDomain.inventory.QtyOnHand);
            }else{
                addStocks = new modalAddStocks(txtBarcode.Text, txtName.Text, 0);
            }
                                     
            DialogResult result = addStocks.ShowDialog();

            if (result == DialogResult.OK)
            {
                inventory = new Inventory()
                {
                    Barcode = txtBarcode.Text,
                    StockinDateTime = DateTime.Now,
                    QtyReceived = addStocks.AdditionalStocks,
                    QtyOnHand = addStocks.AdditionalStocks,
                };

                if (checkIfProductAlreadyExists(txtBarcode.Text))
                {
                    dbController.insertInventory(inventory);
                }
                else
                {
                    int category_id = dbController.categoryMapper.getCategoryIndexFromName(cbCategory.Text);
                    int supplier_id = dbController.supplierMapper.getSupplierIdByName(cbSupplier.Text);

                    product = new Product()
                    {
                        Barcode = txtBarcode.Text,
                        SerialCode = txtSerialCode.Text,
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        SupplierId = supplier_id,
                        Unit = cbUnit.Text,
                        UnitCost = decimal.Parse(txtUnitCost.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        MaintainingStocks = int.Parse(txtMaintainingStocks.Text),
                        Warranty = txtWarranty.Text.ToString(),
                        Replacement = txtReplacement.Text.ToString(),
                        Category_id = category_id,
                    };

                    dbController.insertProductInsideInventory(inventory, product);
                }
            }
       
            toggle();    
        }

        public void clearTexts()
        {
            MyExtension.Validation.clearFields(contentPanel);
            cbCategory.Text = "";
            txtBarcode.Enabled = true; // To make sure it is enabled even after update
            loadCategoryList();
            loadSupplierList();
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

                txtSerialCode.Text = product.SerialCode.ToString();
                loadCategory();
                loadSupplier();
                txtUnitCost.Text = product.UnitCost.ToString();

                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtMaintainingStocks.Text = product.MaintainingStocks.ToString();
                cbUnit.Text = product.Unit;

                oldProduct = product;

            }catch(Exception ex){
                ErrorLog.Log(ex);
            }
            
          
        }

        void loadCategory()
        {
            string category = dbController.categoryMapper.getCategoryNameFromId(product.Category_id);
            cbCategory.Text = category;
        }

        void loadSupplier()
        {
            string supplier = dbController.supplierMapper.getSupplierNameFromId(product.SupplierId);
            cbSupplier.Text = supplier;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OK();
        }

        public bool OK()
        {
            if (MyExtension.Validation.isFilled(contentPanel))
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
            return MyExtension.Validation.isFilled(contentPanel);
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
            }
        }

        public bool isFilled()
        {
            return MyExtension.Validation.isFilled(contentPanel);
        }

        void updateProduct()
        {
            if (MyExtension.Validation.isFilled(contentPanel))
            {
                int category_id = dbController.categoryMapper.getCategoryIndexFromName(cbCategory.Text);
                int supplier_id = dbController.supplierMapper.getSupplierIdByName(cbSupplier.Text);

                product = new Product()
                {
                    Barcode = txtBarcode.Text,
                    SerialCode = txtSerialCode.Text,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    SupplierId = supplier_id,
                    Unit = cbUnit.Text,
                    UnitCost = decimal.Parse(txtUnitCost.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    MaintainingStocks = int.Parse(txtMaintainingStocks.Text),
                    Warranty = txtWarranty.Text.ToString(),
                    Replacement = txtReplacement.Text.ToString(),
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
            loadSupplierList();
         //   masterController.setFormReturnkey = button1
        }

        public void loadCategoryList()
        {
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(dbController.getListOfCategory().ToArray());
        }

        public void loadSupplierList()
        {
            cbSupplier.Items.Clear();
            cbSupplier.Items.AddRange(dbController.supplierMapper.getSupplierList().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modalAddCategory categoryModal = new modalAddCategory(dbController, this);
            categoryModal.ShowDialog();
            masterController.setFormReturnkey = null;

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            MyExtension.Validation.limitTextbox(sender as TextBox, ".1234567890");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Validation.filterToAlphaNumeric(sender as TextBox);
        }

        private void txtMaintainingStocks_TextChanged(object sender, EventArgs e)
        {
            Validation.filterToNumeric(sender as TextBox);
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            Validation.filterToDecimal(sender as TextBox);
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            Validation.filterToDecimal(sender as TextBox);
        }
    }
}
