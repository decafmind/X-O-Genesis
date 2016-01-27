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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_miniView = new System.Windows.Forms.Panel();
            this.panel_basicInfo = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaintaining = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSerialCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtUCost = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtReplacement = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_basicInfo.SuspendLayout();
            this.SuspendLayout();
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
            // panel_miniView
            // 
            this.panel_miniView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_miniView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_miniView.Location = new System.Drawing.Point(391, 0);
            this.panel_miniView.Name = "panel_miniView";
            this.panel_miniView.Size = new System.Drawing.Size(468, 579);
            this.panel_miniView.TabIndex = 1;
            this.panel_miniView.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_miniView_Paint);
            // 
            // panel_basicInfo
            // 
            this.panel_basicInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_basicInfo.Controls.Add(this.lblTitle);
            this.panel_basicInfo.Controls.Add(this.label14);
            this.panel_basicInfo.Controls.Add(this.txtMaintaining);
            this.panel_basicInfo.Controls.Add(this.txtUnit);
            this.panel_basicInfo.Controls.Add(this.label13);
            this.panel_basicInfo.Controls.Add(this.txtSupplier);
            this.panel_basicInfo.Controls.Add(this.label12);
            this.panel_basicInfo.Controls.Add(this.txtDescription);
            this.panel_basicInfo.Controls.Add(this.label11);
            this.panel_basicInfo.Controls.Add(this.txtSerialCode);
            this.panel_basicInfo.Controls.Add(this.label10);
            this.panel_basicInfo.Controls.Add(this.txtUnitPrice);
            this.panel_basicInfo.Controls.Add(this.btnClose);
            this.panel_basicInfo.Controls.Add(this.txtQty);
            this.panel_basicInfo.Controls.Add(this.txtItemCode);
            this.panel_basicInfo.Controls.Add(this.txtName);
            this.panel_basicInfo.Controls.Add(this.txtCategory);
            this.panel_basicInfo.Controls.Add(this.txtUCost);
            this.panel_basicInfo.Controls.Add(this.txtWarranty);
            this.panel_basicInfo.Controls.Add(this.txtReplacement);
            this.panel_basicInfo.Controls.Add(this.label9);
            this.panel_basicInfo.Controls.Add(this.label8);
            this.panel_basicInfo.Controls.Add(this.label7);
            this.panel_basicInfo.Controls.Add(this.label5);
            this.panel_basicInfo.Controls.Add(this.label4);
            this.panel_basicInfo.Controls.Add(this.label3);
            this.panel_basicInfo.Controls.Add(this.label2);
            this.panel_basicInfo.Controls.Add(this.label1);
            this.panel_basicInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_basicInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_basicInfo.Name = "panel_basicInfo";
            this.panel_basicInfo.Size = new System.Drawing.Size(391, 579);
            this.panel_basicInfo.TabIndex = 0;
            this.panel_basicInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_basicInfo_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(14, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Maintaining stocks:";
            // 
            // txtMaintaining
            // 
            this.txtMaintaining.Location = new System.Drawing.Point(125, 275);
            this.txtMaintaining.Name = "txtMaintaining";
            this.txtMaintaining.Size = new System.Drawing.Size(251, 20);
            this.txtMaintaining.TabIndex = 28;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(125, 237);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(251, 20);
            this.txtUnit.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Unit of stocks:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(125, 200);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(251, 20);
            this.txtSupplier.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(14, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Supplier name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(125, 163);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(251, 20);
            this.txtDescription.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Description:";
            // 
            // txtSerialCode
            // 
            this.txtSerialCode.Location = new System.Drawing.Point(125, 93);
            this.txtSerialCode.Name = "txtSerialCode";
            this.txtSerialCode.Size = new System.Drawing.Size(251, 20);
            this.txtSerialCode.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Serial Code:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(125, 384);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(251, 20);
            this.txtUnitPrice.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Cancel_2;
            this.btnClose.Location = new System.Drawing.Point(246, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 58);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(125, 494);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(251, 20);
            this.txtQty.TabIndex = 17;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(125, 60);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(251, 20);
            this.txtItemCode.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 20);
            this.txtName.TabIndex = 15;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(125, 313);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(251, 20);
            this.txtCategory.TabIndex = 14;
            // 
            // txtUCost
            // 
            this.txtUCost.Location = new System.Drawing.Point(125, 347);
            this.txtUCost.Name = "txtUCost";
            this.txtUCost.Size = new System.Drawing.Size(251, 20);
            this.txtUCost.TabIndex = 13;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(125, 424);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(251, 20);
            this.txtWarranty.TabIndex = 11;
            // 
            // txtReplacement
            // 
            this.txtReplacement.Location = new System.Drawing.Point(125, 459);
            this.txtReplacement.Name = "txtReplacement";
            this.txtReplacement.Size = new System.Drawing.Size(251, 20);
            this.txtReplacement.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Quantity On-Hand:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Replacement Period:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Warranty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product code:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DimGray;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(391, 47);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "PRODUCT INTERVIEW";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.ResumeLayout(false);
            this.panel_basicInfo.ResumeLayout(false);
            this.panel_basicInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_miniView;
        private System.Windows.Forms.Panel panel_basicInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtUCost;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtReplacement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaintaining;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSerialCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTitle;
    }
}