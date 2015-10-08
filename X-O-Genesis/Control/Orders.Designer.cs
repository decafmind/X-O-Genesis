namespace PetvetPOS_Inventory_System
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransactionno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.poSlbl2 = new PetvetPOS_Inventory_System.POSlbl();
            this.clientNames_listView = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.keyButton1 = new PetvetPOS_Inventory_System.KeyButton();
            this.keyButton4 = new PetvetPOS_Inventory_System.KeyButton();
            this.keyButton3 = new PetvetPOS_Inventory_System.KeyButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.lblTransactionno);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.btnEncode);
            this.panel11.Location = new System.Drawing.Point(8, 8);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(247, 119);
            this.panel11.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel10.Controls.Add(this.txtQuantity);
            this.panel10.Controls.Add(this.btnQuantity);
            this.panel10.Location = new System.Drawing.Point(119, 41);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(115, 30);
            this.panel10.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(2, 2);
            this.txtQuantity.MaxLength = 20;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(111, 26);
            this.txtQuantity.TabIndex = 0;
            // 
            // btnQuantity
            // 
            this.btnQuantity.Location = new System.Drawing.Point(40, 6);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnQuantity.TabIndex = 1;
            this.btnQuantity.Text = "button1";
            this.btnQuantity.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ORDER #";
            // 
            // lblTransactionno
            // 
            this.lblTransactionno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransactionno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionno.Location = new System.Drawing.Point(119, 11);
            this.lblTransactionno.Name = "lblTransactionno";
            this.lblTransactionno.Size = new System.Drawing.Size(115, 23);
            this.lblTransactionno.TabIndex = 3;
            this.lblTransactionno.Text = "0";
            this.lblTransactionno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "QUANTITY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txtEncode);
            this.panel3.Location = new System.Drawing.Point(119, 77);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(115, 30);
            this.panel3.TabIndex = 1;
            // 
            // txtEncode
            // 
            this.txtEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncode.Enabled = false;
            this.txtEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncode.Location = new System.Drawing.Point(2, 2);
            this.txtEncode.MaxLength = 20;
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(111, 26);
            this.txtEncode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "SCAN";
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.White;
            this.btnEncode.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.barcodeSearch;
            this.btnEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Location = new System.Drawing.Point(64, 77);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(49, 30);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.poSlbl2);
            this.panel2.Location = new System.Drawing.Point(261, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 119);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL";
            // 
            // poSlbl2
            // 
            this.poSlbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.poSlbl2.Location = new System.Drawing.Point(12, 47);
            this.poSlbl2.Name = "poSlbl2";
            this.poSlbl2.Size = new System.Drawing.Size(204, 46);
            this.poSlbl2.TabIndex = 13;
            // 
            // clientNames_listView
            // 
            this.clientNames_listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientNames_listView.FullRowSelect = true;
            this.clientNames_listView.GridLines = true;
            this.clientNames_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.clientNames_listView.Location = new System.Drawing.Point(14, 133);
            this.clientNames_listView.MultiSelect = false;
            this.clientNames_listView.Name = "clientNames_listView";
            this.clientNames_listView.Size = new System.Drawing.Size(472, 366);
            this.clientNames_listView.TabIndex = 43;
            this.clientNames_listView.TabStop = false;
            this.clientNames_listView.UseCompatibleStateImageBehavior = false;
            this.clientNames_listView.View = System.Windows.Forms.View.List;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.keyButton1);
            this.panel4.Controls.Add(this.keyButton4);
            this.panel4.Controls.Add(this.keyButton3);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 515);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 59);
            this.panel4.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Start";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(685, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 42);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // keyButton1
            // 
            this.keyButton1.accessKeyChar = "F1";
            this.keyButton1.accessMasterController = null;
            this.keyButton1.BackColor = System.Drawing.Color.Transparent;
            this.keyButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton1.Location = new System.Drawing.Point(3, 5);
            this.keyButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton1.Name = "keyButton1";
            this.keyButton1.Size = new System.Drawing.Size(61, 50);
            this.keyButton1.TabIndex = 16;
            // 
            // keyButton4
            // 
            this.keyButton4.accessKeyChar = "F4";
            this.keyButton4.accessMasterController = null;
            this.keyButton4.BackColor = System.Drawing.Color.Transparent;
            this.keyButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton4.Location = new System.Drawing.Point(298, 4);
            this.keyButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton4.Name = "keyButton4";
            this.keyButton4.Size = new System.Drawing.Size(61, 50);
            this.keyButton4.TabIndex = 19;
            // 
            // keyButton3
            // 
            this.keyButton3.accessKeyChar = "F3";
            this.keyButton3.accessMasterController = null;
            this.keyButton3.BackColor = System.Drawing.Color.Transparent;
            this.keyButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton3.Location = new System.Drawing.Point(156, 4);
            this.keyButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton3.Name = "keyButton3";
            this.keyButton3.Size = new System.Drawing.Size(61, 50);
            this.keyButton3.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(364, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Void Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Reset";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.clientNames_listView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel11);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(500, 574);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTransactionno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private POSlbl poSlbl2;
        private System.Windows.Forms.ListView clientNames_listView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private KeyButton keyButton1;
        private KeyButton keyButton4;
        private KeyButton keyButton3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
