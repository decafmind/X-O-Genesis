namespace PetvetPOS_Inventory_System
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartBestSellers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pawPrint1 = new PetvetPOS_Inventory_System.PawPrint();
            this.criticalPanel = new System.Windows.Forms.Panel();
            this.dgCritical = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.bestSellerPanel = new System.Windows.Forms.Panel();
            this.dGBestSellers = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgReturnedProduct = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestSellers)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.criticalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCritical)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bestSellerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGBestSellers)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnedProduct)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartBestSellers
            // 
            this.chartBestSellers.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartBestSellers.ChartAreas.Add(chartArea1);
            this.chartBestSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartBestSellers.Legends.Add(legend1);
            this.chartBestSellers.Location = new System.Drawing.Point(301, 0);
            this.chartBestSellers.Name = "chartBestSellers";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBestSellers.Series.Add(series1);
            this.chartBestSellers.Size = new System.Drawing.Size(286, 583);
            this.chartBestSellers.TabIndex = 5;
            this.chartBestSellers.Text = "chart1";
            this.chartBestSellers.Click += new System.EventHandler(this.chartBestSellers_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 82);
            this.label6.TabIndex = 6;
            this.label6.Text = "Percentage Share of Best Sellers Product";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.pawPrint1);
            this.mainPanel.Controls.Add(this.criticalPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(301, 583);
            this.mainPanel.TabIndex = 0;
            // 
            // pawPrint1
            // 
            this.pawPrint1.Location = new System.Drawing.Point(3, 3);
            this.pawPrint1.Name = "pawPrint1";
            this.pawPrint1.PawColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pawPrint1.Size = new System.Drawing.Size(55, 59);
            this.pawPrint1.TabIndex = 6;
            // 
            // criticalPanel
            // 
            this.criticalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.criticalPanel.Controls.Add(this.dgCritical);
            this.criticalPanel.Controls.Add(this.panel1);
            this.criticalPanel.Controls.Add(this.panel2);
            this.criticalPanel.Location = new System.Drawing.Point(16, 70);
            this.criticalPanel.Name = "criticalPanel";
            this.criticalPanel.Padding = new System.Windows.Forms.Padding(5);
            this.criticalPanel.Size = new System.Drawing.Size(269, 463);
            this.criticalPanel.TabIndex = 3;
            // 
            // dgCritical
            // 
            this.dgCritical.AllowUserToAddRows = false;
            this.dgCritical.AllowUserToDeleteRows = false;
            this.dgCritical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCritical.BackgroundColor = System.Drawing.Color.White;
            this.dgCritical.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCritical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCritical.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgCritical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCritical.Location = new System.Drawing.Point(5, 78);
            this.dgCritical.Name = "dgCritical";
            this.dgCritical.ReadOnly = true;
            this.dgCritical.RowHeadersVisible = false;
            this.dgCritical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCritical.Size = new System.Drawing.Size(259, 268);
            this.dgCritical.TabIndex = 0;
            this.dgCritical.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 73);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products on Critical level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 112);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Products below 20%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Products below 10%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "LEGEND:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(259, 112);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(180)))), ((int)(((byte)(13)))));
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.Location = new System.Drawing.Point(30, 72);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(29, 23);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(29, 38);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(29, 23);
            // 
            // bestSellerPanel
            // 
            this.bestSellerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(158)))), ((int)(((byte)(99)))));
            this.bestSellerPanel.Controls.Add(this.dGBestSellers);
            this.bestSellerPanel.Controls.Add(this.panel4);
            this.bestSellerPanel.Location = new System.Drawing.Point(13, 10);
            this.bestSellerPanel.Name = "bestSellerPanel";
            this.bestSellerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.bestSellerPanel.Size = new System.Drawing.Size(265, 330);
            this.bestSellerPanel.TabIndex = 4;
            // 
            // dGBestSellers
            // 
            this.dGBestSellers.AllowUserToAddRows = false;
            this.dGBestSellers.AllowUserToDeleteRows = false;
            this.dGBestSellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGBestSellers.BackgroundColor = System.Drawing.Color.White;
            this.dGBestSellers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGBestSellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGBestSellers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGBestSellers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGBestSellers.Location = new System.Drawing.Point(5, 50);
            this.dGBestSellers.Name = "dGBestSellers";
            this.dGBestSellers.ReadOnly = true;
            this.dGBestSellers.RowHeadersVisible = false;
            this.dGBestSellers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGBestSellers.Size = new System.Drawing.Size(255, 275);
            this.dGBestSellers.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 45);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(158)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Best Sellers";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(157)))));
            this.panel3.Controls.Add(this.dgReturnedProduct);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(13, 350);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(265, 228);
            this.panel3.TabIndex = 5;
            // 
            // dgReturnedProduct
            // 
            this.dgReturnedProduct.AllowUserToAddRows = false;
            this.dgReturnedProduct.AllowUserToDeleteRows = false;
            this.dgReturnedProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReturnedProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgReturnedProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgReturnedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReturnedProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgReturnedProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReturnedProduct.Location = new System.Drawing.Point(5, 47);
            this.dgReturnedProduct.Name = "dgReturnedProduct";
            this.dgReturnedProduct.ReadOnly = true;
            this.dgReturnedProduct.RowHeadersVisible = false;
            this.dgReturnedProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReturnedProduct.Size = new System.Drawing.Size(255, 176);
            this.dgReturnedProduct.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 42);
            this.panel5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(157)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 42);
            this.label7.TabIndex = 1;
            this.label7.Text = "Returned product";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bestSellerPanel);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(587, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 583);
            this.panel6.TabIndex = 7;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chartBestSellers);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel6);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(877, 583);
            this.Resize += new System.EventHandler(this.Home_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chartBestSellers)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.criticalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCritical)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bestSellerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGBestSellers)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReturnedProduct)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCritical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel bestSellerPanel;
        private System.Windows.Forms.DataGridView dGBestSellers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel criticalPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBestSellers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgReturnedProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private PawPrint pawPrint1;
        private System.Windows.Forms.Panel panel6;
    }
}
