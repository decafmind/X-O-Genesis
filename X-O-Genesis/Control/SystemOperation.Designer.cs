namespace PetvetPOS_Inventory_System
{
    partial class SystemOperation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbAuditTrail = new System.Windows.Forms.PictureBox();
            this.pbLoginTrail = new System.Windows.Forms.PictureBox();
            this.pbPromoAndDiscount = new System.Windows.Forms.PictureBox();
            this.pbUserManagement = new System.Windows.Forms.PictureBox();
            this.pbSystemSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuditTrail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginTrail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromoAndDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSystemSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(86, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "System Settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(342, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(615, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promos and Discount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(258, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Login trail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(529, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Audit trail";
            // 
            // pbAuditTrail
            // 
            this.pbAuditTrail.BackColor = System.Drawing.Color.Transparent;
            this.pbAuditTrail.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.userWhite;
            this.pbAuditTrail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAuditTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAuditTrail.Location = new System.Drawing.Point(516, 290);
            this.pbAuditTrail.Name = "pbAuditTrail";
            this.pbAuditTrail.Size = new System.Drawing.Size(117, 105);
            this.pbAuditTrail.TabIndex = 4;
            this.pbAuditTrail.TabStop = false;
            this.pbAuditTrail.Click += new System.EventHandler(this.pbAuditTrail_Click);
            // 
            // pbLoginTrail
            // 
            this.pbLoginTrail.BackColor = System.Drawing.Color.Transparent;
            this.pbLoginTrail.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.usersIcon;
            this.pbLoginTrail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLoginTrail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLoginTrail.Location = new System.Drawing.Point(243, 290);
            this.pbLoginTrail.Name = "pbLoginTrail";
            this.pbLoginTrail.Size = new System.Drawing.Size(116, 105);
            this.pbLoginTrail.TabIndex = 3;
            this.pbLoginTrail.TabStop = false;
            this.pbLoginTrail.Click += new System.EventHandler(this.pbLoginTrail_Click);
            // 
            // pbPromoAndDiscount
            // 
            this.pbPromoAndDiscount.BackColor = System.Drawing.Color.Transparent;
            this.pbPromoAndDiscount.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.documentIcon;
            this.pbPromoAndDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPromoAndDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPromoAndDiscount.Location = new System.Drawing.Point(640, 50);
            this.pbPromoAndDiscount.Name = "pbPromoAndDiscount";
            this.pbPromoAndDiscount.Size = new System.Drawing.Size(116, 105);
            this.pbPromoAndDiscount.TabIndex = 2;
            this.pbPromoAndDiscount.TabStop = false;
            // 
            // pbUserManagement
            // 
            this.pbUserManagement.BackColor = System.Drawing.Color.Transparent;
            this.pbUserManagement.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.userBlack;
            this.pbUserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserManagement.Location = new System.Drawing.Point(363, 50);
            this.pbUserManagement.Name = "pbUserManagement";
            this.pbUserManagement.Size = new System.Drawing.Size(117, 105);
            this.pbUserManagement.TabIndex = 1;
            this.pbUserManagement.TabStop = false;
            this.pbUserManagement.Click += new System.EventHandler(this.pbUserManagement_Click);
            // 
            // pbSystemSettings
            // 
            this.pbSystemSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSystemSettings.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.settingsIcon;
            this.pbSystemSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSystemSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSystemSettings.Location = new System.Drawing.Point(90, 50);
            this.pbSystemSettings.Name = "pbSystemSettings";
            this.pbSystemSettings.Size = new System.Drawing.Size(116, 105);
            this.pbSystemSettings.TabIndex = 0;
            this.pbSystemSettings.TabStop = false;
            this.pbSystemSettings.Click += new System.EventHandler(this.pbSystemSettings_Click);
            // 
            // SystemOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbAuditTrail);
            this.Controls.Add(this.pbLoginTrail);
            this.Controls.Add(this.pbPromoAndDiscount);
            this.Controls.Add(this.pbUserManagement);
            this.Controls.Add(this.pbSystemSettings);
            this.Name = "SystemOperation";
            this.Size = new System.Drawing.Size(877, 583);
            this.Load += new System.EventHandler(this.SystemOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAuditTrail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginTrail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPromoAndDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSystemSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSystemSettings;
        private System.Windows.Forms.PictureBox pbUserManagement;
        private System.Windows.Forms.PictureBox pbPromoAndDiscount;
        private System.Windows.Forms.PictureBox pbAuditTrail;
        private System.Windows.Forms.PictureBox pbLoginTrail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
