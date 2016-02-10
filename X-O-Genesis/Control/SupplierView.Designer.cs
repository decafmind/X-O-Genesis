namespace PetvetPOS_Inventory_System
{
    partial class SupplierView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(36, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(35, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contact number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(38, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSupplierName.Location = new System.Drawing.Point(36, 52);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(390, 49);
            this.lblSupplierName.TabIndex = 6;
            this.lblSupplierName.Text = "Supplier name";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSupplierAddress.Location = new System.Drawing.Point(180, 132);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(244, 58);
            this.lblSupplierAddress.TabIndex = 10;
            this.lblSupplierAddress.Text = "Address";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblContactNumber.Location = new System.Drawing.Point(180, 203);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(244, 19);
            this.lblContactNumber.TabIndex = 11;
            this.lblContactNumber.Text = "Address";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblContactPerson.Location = new System.Drawing.Point(180, 243);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(244, 19);
            this.lblContactPerson.TabIndex = 12;
            this.lblContactPerson.Text = "Address";
            // 
            // SupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblContactPerson);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblSupplierAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSupplierName);
            this.Name = "SupplierView";
            this.Size = new System.Drawing.Size(463, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblContactPerson;
    }
}
