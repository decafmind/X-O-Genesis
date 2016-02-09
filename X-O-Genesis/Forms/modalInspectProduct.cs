using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

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
            displayGraph();
        }


        private void displayBasicInfo()
        {
            ProductInventoryDomain productInventory = dbController.productInventory.getProductInventoryThroughBarcode(bcode);
            Product product = productInventory.product;
            Inventory inventory = productInventory.inventory;

            txtItemCode.Text = product.Barcode;
            txtSerialCode.Text = product.SerialCode;
            txtName.Text = product.Name;
            txtDescription.Text = product.Description;

            txtSupplier.Text = product.SupplierName;
            txtUnit.Text = product.Unit;
            txtMaintaining.Text = product.MaintainingStocks.ToString();
            txtCategory.Text = product.Category;

            txtUCost.Text = product.UnitCost.ToString();
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtWarranty.Text = product.Warranty;
            txtReplacement.Text = product.Replacement;

            txtQty.Text = inventory.QtyOnHand.ToString();
        }

        private void modalInspectProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                this.Close();
        }

        void displayGraph()
        {
            DataTable dt = new DataTable();
            dt = dbController.getStockMovement(dt, bcode);

            string chartTitle = "Stock Movement";
            stockMovement.Series.Clear();
            stockMovement.ResetAutoValues();
            stockMovement.Series.Add(chartTitle);

            stockMovement.Series[chartTitle].ChartType = SeriesChartType.Column;
            stockMovement.Series[chartTitle].Font = new Font("Times New Roman", 8, FontStyle.Bold);
            stockMovement.Series[chartTitle].LabelForeColor = Color.White;
            stockMovement.Series[chartTitle].SetCustomProperty("DrawingStyle", "lightToDark");

            foreach (DataRow row in dt.Rows)
            {
                int qtySold = Convert.ToInt32(dt.Rows[0]["QTYSold"]);

                int pointX = Convert.ToInt32(dt.Rows[0]["Month"]);
                int months = 12;
                for(int i = 1; i < months; i++)
                {                   
                    if(i == pointX)                       
                        stockMovement.Series[chartTitle].Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(pointX), qtySold);
                    else
                        stockMovement.Series[chartTitle].Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i), 0);
                }
            }
        }

        private void panel_miniView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_basicInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
