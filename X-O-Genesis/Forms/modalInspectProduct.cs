using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class modalInspectProduct : Form
    {
        DatabaseController dbController;
        DataTable dtBasicInfo = new DataTable();
        InventoryView invView = new InventoryView();

        public string bcode;
        public modalInspectProduct(DatabaseController dbController)
        {
            InitializeComponent();
            this.dbController = dbController;
        }
        public modalInspectProduct()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modalInspectProduct_Load(object sender, EventArgs e)
        {
            displayBasicInfo();
        }


        private void displayBasicInfo()
        {
            ProductInventoryDomain productInventory = dbController.productInventory.getProductInventoryThroughBarcode(bcode);
            Product product = productInventory.product;
            Inventory inventory = productInventory.inventory;

            txtItemCode.Text = product.Barcode;
            txtName.Text = product.Name;
            txtDescription.Text = product.Description;
            txtCategory.Text = product.Category;
            txtQty.Text = inventory.QtyOnHand.ToString();
            txtSupplier.Text = product.SupplierName;
            txtWarranty.Text = product.Warranty;
            txtReplacement.Text = product.Replacement;

            txtItemCode.Focus();
        }

        private void modalInspectProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                this.Close();
        }

        private void panel_miniView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_basicInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
