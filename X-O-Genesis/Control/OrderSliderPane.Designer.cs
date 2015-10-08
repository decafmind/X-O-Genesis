namespace PetvetPOS_Inventory_System
{
    partial class OrderSliderPane
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
            this.orders1 = new PetvetPOS_Inventory_System.Orders();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(129, 17);
            // 
            // orders1
            // 
            this.orders1.Location = new System.Drawing.Point(3, 3);
            this.orders1.Name = "orders1";
            this.orders1.Size = new System.Drawing.Size(500, 574);
            this.orders1.TabIndex = 1;
            // 
            // OrderSliderPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orders1);
            this.Name = "OrderSliderPane";
            this.Size = new System.Drawing.Size(501, 617);
            this.Load += new System.EventHandler(this.OrderSliderPane_Load);
            this.Controls.SetChildIndex(this.contentPanel, 0);
            this.Controls.SetChildIndex(this.orders1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Orders orders1;

    }
}
