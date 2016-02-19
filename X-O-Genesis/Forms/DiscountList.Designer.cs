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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel_Discounts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Discounts
            // 
            this.panel_Discounts.Controls.Add(this.panel1);
            this.panel_Discounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Discounts.Location = new System.Drawing.Point(0, 0);
            this.panel_Discounts.Name = "panel_Discounts";
            this.panel_Discounts.Padding = new System.Windows.Forms.Padding(10);
            this.panel_Discounts.Size = new System.Drawing.Size(292, 573);
            this.panel_Discounts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 73);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Discounts";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(164, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "No Discount";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // DiscountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(292, 573);
            this.Controls.Add(this.panel_Discounts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiscountList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscountList";
            this.Load += new System.EventHandler(this.DiscountList_Load);
            this.panel_Discounts.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Discounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}