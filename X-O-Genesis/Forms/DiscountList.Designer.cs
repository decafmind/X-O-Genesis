namespace PetvetPOS_Inventory_System
{
    partial class DiscountList
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
            this.panel_Discounts = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDiscountedTotal = new System.Windows.Forms.Label();
            this.panel_Discounts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Discounts
            // 
            this.panel_Discounts.Controls.Add(this.panel2);
            this.panel_Discounts.Controls.Add(this.button1);
            this.panel_Discounts.Controls.Add(this.panel1);
            this.panel_Discounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Discounts.Location = new System.Drawing.Point(0, 0);
            this.panel_Discounts.Name = "panel_Discounts";
            this.panel_Discounts.Padding = new System.Windows.Forms.Padding(10);
            this.panel_Discounts.Size = new System.Drawing.Size(389, 600);
            this.panel_Discounts.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDiscountedTotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 38);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISCOUNTED TOTAL:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 517);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 73);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClose.Image = global::PetvetPOS_Inventory_System.Properties.Resources.NoDISCOUNTS2;
            this.btnClose.Location = new System.Drawing.Point(185, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 58);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CANCEL DISCOUNT";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Image = global::PetvetPOS_Inventory_System.Properties.Resources.addDiscount2;
            this.btnAdd.Location = new System.Drawing.Point(5, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 58);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "AVAIL DISCOUNT";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiscountedTotal
            // 
            this.lblDiscountedTotal.AutoSize = true;
            this.lblDiscountedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountedTotal.Location = new System.Drawing.Point(178, 11);
            this.lblDiscountedTotal.Name = "lblDiscountedTotal";
            this.lblDiscountedTotal.Size = new System.Drawing.Size(17, 17);
            this.lblDiscountedTotal.TabIndex = 4;
            this.lblDiscountedTotal.Text = "0";
            // 
            // DiscountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(389, 600);
            this.Controls.Add(this.panel_Discounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountList";
            this.Load += new System.EventHandler(this.DiscountList_Load);
            this.panel_Discounts.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Discounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDiscountedTotal;
    }
}