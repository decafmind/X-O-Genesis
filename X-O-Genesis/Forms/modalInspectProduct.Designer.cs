namespace PetvetPOS_Inventory_System
{
    partial class modalInspectProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_basicInfo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stockMovement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtMaintaining = new System.Windows.Forms.TextBox();
            this.txtUCost = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplacement = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerialCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel_miniView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_basicInfo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockMovement)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_basicInfo
            // 
            this.panel_basicInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_basicInfo.Controls.Add(this.panel3);
            this.panel_basicInfo.Controls.Add(this.panel2);
            this.panel_basicInfo.Controls.Add(this.lblTitle);
            this.panel_basicInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_basicInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_basicInfo.Name = "panel_basicInfo";
            this.panel_basicInfo.Size = new System.Drawing.Size(859, 579);
            this.panel_basicInfo.TabIndex = 0;
            this.panel_basicInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_basicInfo_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.stockMovement);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(859, 255);
            this.panel3.TabIndex = 32;
            // 
            // stockMovement
            // 
            chartArea1.Name = "ChartArea1";
            this.stockMovement.ChartAreas.Add(chartArea1);
            this.stockMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.stockMovement.Legends.Add(legend1);
            this.stockMovement.Location = new System.Drawing.Point(0, 0);
            this.stockMovement.Name = "stockMovement";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.stockMovement.Series.Add(series1);
            this.stockMovement.Size = new System.Drawing.Size(859, 255);
            this.stockMovement.TabIndex = 2;
            this.stockMovement.Text = "Stock Movement";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.txtMaintaining);
            this.panel2.Controls.Add(this.txtUCost);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.txtUnit);
            this.panel2.Controls.Add(this.txtWarranty);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtReplacement);
            this.panel2.Controls.Add(this.txtSupplier);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSerialCode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtItemCode);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 279);
            this.panel2.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(13, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Maintaining stocks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(382, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Category:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(494, 8);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(251, 20);
            this.txtCategory.TabIndex = 41;
            // 
            // txtMaintaining
            // 
            this.txtMaintaining.Location = new System.Drawing.Point(124, 227);
            this.txtMaintaining.Name = "txtMaintaining";
            this.txtMaintaining.Size = new System.Drawing.Size(251, 20);
            this.txtMaintaining.TabIndex = 55;
            // 
            // txtUCost
            // 
            this.txtUCost.Location = new System.Drawing.Point(494, 42);
            this.txtUCost.Name = "txtUCost";
            this.txtUCost.Size = new System.Drawing.Size(251, 20);
            this.txtUCost.TabIndex = 40;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(494, 189);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(251, 20);
            this.txtQty.TabIndex = 44;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(124, 189);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(251, 20);
            this.txtUnit.TabIndex = 54;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(494, 119);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(251, 20);
            this.txtWarranty.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product code:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(12, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Unit of stocks:";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Cancel_2;
            this.btnClose.Location = new System.Drawing.Point(615, 211);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 58);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Name:";
            // 
            // txtReplacement
            // 
            this.txtReplacement.Location = new System.Drawing.Point(494, 154);
            this.txtReplacement.Name = "txtReplacement";
            this.txtReplacement.Size = new System.Drawing.Size(251, 20);
            this.txtReplacement.TabIndex = 38;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(124, 152);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(251, 20);
            this.txtSupplier.TabIndex = 52;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(494, 79);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(251, 20);
            this.txtUnitPrice.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Supplier name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(382, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Quantity On-Hand:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(124, 115);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 20);
            this.txtDescription.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(382, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Replacement Period:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(12, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(382, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Warranty:";
            // 
            // txtSerialCode
            // 
            this.txtSerialCode.Location = new System.Drawing.Point(124, 45);
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(251, 20);
            this.txtSerialCode.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(382, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Unit Cost:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Serial Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(382, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Unit Price:";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(124, 12);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(251, 20);
            this.txtItemCode.TabIndex = 43;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 20);
            this.txtName.TabIndex = 42;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(859, 47);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "PRODUCT OVERVIEW";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_miniView
            // 
            this.panel_miniView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_miniView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_miniView.Location = new System.Drawing.Point(0, 0);
            this.panel_miniView.Name = "panel_miniView";
            this.panel_miniView.Size = new System.Drawing.Size(859, 0);
            this.panel_miniView.TabIndex = 1;
            this.panel_miniView.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_miniView_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_miniView);
            this.panel1.Controls.Add(this.panel_basicInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 579);
            this.panel1.TabIndex = 0;
            // 
            // modalInspectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 579);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modalInspectProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Overview";
            this.Load += new System.EventHandler(this.modalInspectProduct_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.modalInspectProduct_KeyUp);
            this.panel_basicInfo.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockMovement)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_basicInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtMaintaining;
        private System.Windows.Forms.TextBox txtUCost;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplacement;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerialCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel_miniView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart stockMovement;

    }
}