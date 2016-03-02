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
using System.Drawing.Printing;

namespace PetvetPOS_Inventory_System
{
    // TODO

    public partial class Sales : MyUserControl, IContentPage, IKeyController
    {
        private int typeOfReporIndex;
        private DataTable dt;

        enum reportType { DAILY, WEEKLY, MONTHLY, UNKNOWN }
        
        reportType currentReport;
        DateTime[] dateRange = new DateTime[2];

        private static int FROM = 0;
        private static int TO = 1;

        private decimal tax;

        reportType checkReportType()
        {
            reportType report = reportType.UNKNOWN;

            if (cmType.Text == "DAILY")
                report = reportType.DAILY;
            else if (cmType.Text == "WEEKLY")
                report = reportType.WEEKLY;
            else if (cmType.Text == "MONTHLY")
                report = reportType.MONTHLY;
            else
            {
                report = reportType.DAILY;
                cmType.Text = "DAILY";
            }
            return report;
        }

        SeriesChartType checkChartType()
        {
            SeriesChartType chartType = SeriesChartType.Column;
            if (cbCharttype.Text == "BAR")
                chartType = SeriesChartType.Column;
            else if (cbCharttype.Text == "LINE")
                chartType = SeriesChartType.Line;
            else
            {
                chartType = SeriesChartType.Column;
                cbCharttype.Text = "BAR";
            }
            

            return chartType;
        }

        public Sales()
        {
            InitializeComponent();
        }

        public Sales(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            MyExtension.Graphics_.avoidPanelFlickering(panelChart);
        }

        void masterController_ServerClock(object sender, EventArgs e)
        {
            initTable();
        }

        public void initializePage()
        {
            typeOfReporIndex = 0;
            changedReportTitle(cmType.Text);
            dtFrom.Value = dtTo.Value - new TimeSpan(30, 0, 0, 0);
            initReport();

            try
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += worker_DoWork;
                worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                worker.RunWorkerAsync();
            }
            catch (InvalidOperationException ioe)
            {
                ErrorLog.Log(ioe);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }

            this.masterController.ServerClock += masterController_ServerClock;
            timer1.Start();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            selectReport();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            formatDataGrid();
            showDailySales();
            initChart();
        }

        void showDailySales()
        {
            dt = new DataTable();

            decimal sales = dbController.getTodaySales().Sales;
            decimal vat = sales * tax;
            decimal totalSales = sales - vat;

            lblTodaysales.Text = String.Format("Php {0}", totalSales.ToString("N"));
        }

        void vatableSalesReport(DataTable dt, decimal tax)
        {
            foreach (DataRow row in dt.Rows)
            {
                decimal vat = Convert.ToDecimal(row["Sales"]) * tax;
                foreach (DataColumn column in dt.Columns)
                {
                    row.SetField("Sales", (Convert.ToDecimal(row["Sales"]) - vat).ToString("N"));
                }
            }
        }

        void selectReport()
        {
            dt = new DataTable();
            DataTable taxTable = new DataTable();

            dbController.loadCompanyProfile(taxTable);
            foreach (DataRow dr in taxTable.Rows)
            {
                tax = Convert.ToDecimal(dr["tax"]);
            }

            switch (currentReport)
            {
                case reportType.DAILY:
                    dbController.filterDailySalesReport(dt, dateRange[FROM], dateRange[TO]);
                    vatableSalesReport(dt, tax);
                    break;
                case reportType.WEEKLY:
                    dbController.filterWeeklySalesReport(dt, dateRange[FROM], dateRange[TO]);
                    vatableSalesReport(dt, tax);
                    break;
                case reportType.MONTHLY:
                    dbController.filterMonthlySalesReport(dt, dateRange[FROM], dateRange[TO]);
                    vatableSalesReport(dt, tax);
                    break;
                case reportType.UNKNOWN:
                    break;
                default:
                    break;
            }
        }

        void initReport()
        {
            currentReport = checkReportType();
            dateRange[FROM] = dtFrom.Value;
            dateRange[TO] = dtTo.Value;
        }

        void formatDataGrid()
        {
            dataGridView2.DataSource = dt;
            dataGridView2.DefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT", 12, FontStyle.Bold);
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        /// <summary>
        /// A wrapper method to
        /// call individual initializations of report, datagrid and chart
        /// </summary>
        void initTable()
        {
            initReport();
            selectReport();
            formatDataGrid();
            showDailySales();
            initChart();
        }
      
        void initChart()
        {
            string seriesName = "";

            salesChart.Series.Clear();
            salesChart.ResetAutoValues();

            if (cmType.Text == "DAILY")
                seriesName = "Daily Sales Report";
            else if (cmType.Text == "WEEKLY")
                seriesName = "Weekly Sales Report";
            else if (cmType.Text == "MONTHLY")
                seriesName = "Monthly Sales Report";

            salesChart.Series.Add(seriesName);
            salesChart.Series[seriesName].ChartType = checkChartType();
            salesChart.Series[seriesName].SetCustomProperty("DrawingStyle", "lightToDark");

            int rowCount = dataGridView2.Rows.Count - 1;
            for (int i = rowCount; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                 salesChart.Series[seriesName].Points.AddXY(row.Cells[0].Value, row.Cells[1].Value);
            }
        }

        public Menu accessMenuName
        {
            get { return Menu.Sales; }
        }


        public Bitmap accessImage
        {
            get { return Properties.Resources.reportIcon; }
        }

        public void finalizePage()
        {
            masterController.ServerClock -= masterController_ServerClock;
            timer1.Stop();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedReportTitle(cmType.Text);
            initTable();
        }

        void changedReportTitle(string title)
        {
            lblTitle.Text = title + string.Format(" SALES \nfrom {0} to {1}", dtFrom.Value.ToShortDateString(), dtTo.Value.ToShortDateString());
        }

        public KeyFunction getKeyController
        {
            get { return Sales_KeyFunction; }
        }

        private void Sales_KeyFunction(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                keyButton1.updateButton();
                selectNextSalesReport();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                keyButton2.updateButton();
                printReport();
            }
            else if (e.KeyCode == Keys.F5)
            {
                initTable();
            }
        }

        void selectNextSalesReport()
        {
            const int MAX_INDEX = 2;
            if (typeOfReporIndex >= MAX_INDEX)
                typeOfReporIndex = 0;
            else
                typeOfReporIndex++;

            cmType.SelectedIndex = typeOfReporIndex;
            changedReportTitle(cmType.Text);
            cmType.Focus();
        }

        void printReport(){
            PrintDocument document = new PrintDocument();
            document.PrintPage += document_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog()
            {
                Width = 600,
                Height = document.DefaultPageSettings.Bounds.Height,
            };
            preview.Document = document;
            preview.ShowDialog(this);
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            using(Font arialRoundedMT = new Font("Arial Rounded MT", 16, FontStyle.Italic))
            using(Font arial = new Font("Arial", 14, FontStyle.Bold))
            using(Font timesNewRoman = new Font("Times New Roman", 14, FontStyle.Regular)){
                int documentHeight = e.PageBounds.Height;
                int documentWidth = e.PageBounds.Width;

                string titleName = "";
                if (cmType.Text == "DAILY")
                    titleName = "Daily Sales Report";
                else if (cmType.Text == "WEEKLY")
                    titleName = "Weekly Sales Report";
                else if (cmType.Text == "MONTHLY")
                    titleName = "Monthly Sales Report";

                DataTable companyProfile = new DataTable();
                dbController.loadCompanyProfile(companyProfile);

                string storeName = "Exogenesis";
                string tin = " Company VAT Registered TIN";
                string address = "Company Address";
                string cont = "Company Contact Number";
                string web = "Company Email / Website";
                decimal tax = 0;

                foreach (DataRow dr in companyProfile.Rows)
                {
                    storeName = dr["compname"].ToString();
                    address = dr["address"].ToString();
                    cont = dr["contactno"].ToString();
                    web = dr["email"].ToString();
                    tin = dr["vat_reg_tin"].ToString();
                    tax = Convert.ToDecimal(dr["tax"]);
                }

                int Y = 50;
                SizeF stringSize = g.MeasureString(titleName, arialRoundedMT);
                g.DrawString(titleName, arialRoundedMT, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y+= (int)stringSize.Height + 10;

                stringSize = g.MeasureString(storeName, arialRoundedMT);
                g.DrawString(storeName, arialRoundedMT, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + 10;

                string dateFrom = dtFrom.Value.ToLongDateString();
                string dateTo = dtTo.Value.ToLongDateString();
                string dateRange = String.Format("{0} - {1}", dateFrom, dateTo);
                stringSize = g.MeasureString(dateRange, arialRoundedMT);
                g.DrawString(dateRange, arialRoundedMT, Brushes.Black, new PointF((documentWidth - stringSize.Width) / 2, Y));
                Y += (int)stringSize.Height + 10;

                g.DrawLine(new Pen(Brushes.Black), new PointF(50, Y), new PointF((documentWidth - 50), Y));
                Y += (int)stringSize.Height + 10;

                // Draw field headers
                g.DrawString("Date", arial, Brushes.Black, new PointF(50, Y));
                stringSize = g.MeasureString("Sales", arial);
                g.DrawString("Sales", arial, Brushes.Black, new PointF((documentWidth - stringSize.Width - 50), Y));
                Y += (int)stringSize.Height + 10;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    string strDate = "";
                    DateTime date = DateTime.Now;
                    if (cmType.Text == "DAILY")
                        date = (DateTime)row.Cells[0].Value;
                    else
                        strDate = row.Cells[0].Value.ToString();

                    string sales =  String.Format("P {0}", row.Cells[1].Value.ToString());

                    // draw dates
                    if(cmType.Text == "DAILY")
                        g.DrawString(date.Date.ToLongDateString(), timesNewRoman, Brushes.Black, new PointF(50, Y));
                    else
                        g.DrawString(strDate, timesNewRoman, Brushes.Black, new PointF(50, Y));
                    // draw sales
                    stringSize = g.MeasureString(sales, timesNewRoman);
                    g.DrawString(sales, timesNewRoman, Brushes.Black, new PointF( (documentWidth - stringSize.Width - 50), Y));
                    // increment Y
                    Y += (int)stringSize.Height + 10;
                }
            }
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            initTable();
            changedReportTitle(cmType.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            initTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbCharttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            initTable();
        }

        private void cmType_DisplayMemberChanged(object sender, EventArgs e)
        {
            initChart();
        }

        private void cmType_TextChanged(object sender, EventArgs e)
        {
       
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
