using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PetvetPOS_Inventory_System
{
    public partial class Home : MyUserControl, IContentPage, IKeyController
    {
        private DataTable dt;
        private const int QUANTITY_ONHAND_INDEX = 1;
        private const int QUANTITY_ONRECEIVED_INDEX = 2;
       
        private const decimal CRITICAL_LEVEL = .10M;
        private const decimal WARNING_LEVEL = .20M;
        private DataGridViewCellStyle critical, warning, normal, cellHeader;

        public Home()
        {
            InitializeComponent();
        }

        public Home(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;

            critical = new DataGridViewCellStyle()
            {
                BackColor = rectangleShape1.BackColor,
                SelectionBackColor = rectangleShape1.BackColor,
            };

            warning = new DataGridViewCellStyle()
            {
                BackColor = rectangleShape2.BackColor,
                SelectionBackColor = rectangleShape2.BackColor,
            };

            normal = new DataGridViewCellStyle()
            {
                Font = new Font("Times New Roman", 14, FontStyle.Regular),
                SelectionBackColor = Color.White,
                SelectionForeColor = Color.Black,
            };

            cellHeader = new DataGridViewCellStyle()
            {
                Font = new Font("Times New Roman", 14, FontStyle.Regular),
                WrapMode = DataGridViewTriState.True,
            };

            MyExtension.Graphics_.avoidPanelFlickering(panelPie);
            MyExtension.Graphics_.avoidPanelFlickering(panel6);
        }

        void masterController_ServerClock(object sender, EventArgs e)
        {
            initTable();
            fillPieChart();
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            mainPanel.Location = new Point((Width - mainPanel.Width) / 2, mainPanel.Location.Y);
        }

        public KeyFunction getKeyController
        {
            get { return Home_KeyFunction; }
        }

        void Home_KeyFunction(KeyEventArgs e)
        {

        }

        public void initializePage()
        {
            initTable();
            fillPieChart();

            this.masterController.ServerClock += masterController_ServerClock;
            timer1.Start();
        }

        void colorCodedRows()
        {

            decimal qty_onhand, qty_received;
            foreach (DataGridViewRow row in dgCritical.Rows)
            {
                qty_onhand = (decimal)row.Cells[QUANTITY_ONHAND_INDEX].Value;
                qty_received = (decimal)row.Cells[QUANTITY_ONRECEIVED_INDEX].Value;
                if (qty_onhand <= (qty_received * CRITICAL_LEVEL))
                    row.DefaultCellStyle.ApplyStyle(critical);
                else if (qty_onhand <= (qty_received * WARNING_LEVEL))
                    row.DefaultCellStyle.ApplyStyle(warning);
            }

        }

        void fillPieChart()
        {
            string chartTitle = "Top 10 Bestsellers";
            chartBestSellers.Series.Clear();
            chartBestSellers.ResetAutoValues();
            chartBestSellers.Series.Add(chartTitle);

            chartBestSellers.Series[chartTitle].ChartType = SeriesChartType.Pie;
            chartBestSellers.Series[chartTitle].Font = new Font("Times New Roman", 8, FontStyle.Bold);
            chartBestSellers.Series[chartTitle]["PieLabelStyle"] = "Outside";
            chartBestSellers.Series[chartTitle]["PieLineColor"] = "Black";
            chartBestSellers.Series[chartTitle].SetCustomProperty("DrawingStyle", "lightToDark");
            chartBestSellers.Series[chartTitle].IsVisibleInLegend = false;

            chartBestSellers.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartBestSellers.ChartAreas[0].Area3DStyle.IsRightAngleAxes = true;
   
            foreach (DataGridViewRow row in dGBestSellers.Rows)
            {
                string productName = row.Cells[0].Value.ToString();
                decimal percentage = (decimal)row.Cells[2].Value;

                string pointX = String.Format("{0} {1}%", productName, (int)percentage);
                chartBestSellers.Series[chartTitle].Points.AddXY(pointX, percentage);
            }
        }

        void initTable()
        {
            dt = new DataTable();
            dbController.getCriticalLevelProducts(dt);
            dgCritical.DataSource = dt;
            dgCritical.ColumnHeadersDefaultCellStyle = cellHeader;
            dgCritical.DefaultCellStyle = normal;
            colorCodedRows();

            dt = new DataTable();
            dbController.getBestSellers(dt);
            dGBestSellers.DataSource = dt;
            dGBestSellers.ColumnHeadersDefaultCellStyle = cellHeader;
            dGBestSellers.DefaultCellStyle = normal;

            dt = new DataTable();
            dbController.productReturnViewMapper.loadTableFromQuery(dt, "SELECT product AS 'Product', supplier AS 'Supplier' FROM product_return_view");
            dgReturnedProduct.DataSource = dt;
            dgReturnedProduct.ColumnHeadersDefaultCellStyle = cellHeader;
            dgReturnedProduct.DefaultCellStyle = normal;

        }
        
        public void finalizePage()
        {
            this.masterController.ServerClock -= masterController_ServerClock;
            timer1.Stop();
        }

        public Menu accessMenuName
        {
            get { return Menu.Home; }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.homeIcon; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            colorCodedRows();
        }

        private void chartBestSellers_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initTable();
            fillPieChart();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgReturnedProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGBestSellers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGBestSellers_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
