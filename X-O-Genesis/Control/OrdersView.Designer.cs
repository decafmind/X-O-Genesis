namespace PetvetPOS_Inventory_System
{
    partial class OrdersView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblPOSmsg = new System.Windows.Forms.Label();
            this.poSlbl2 = new PetvetPOS_Inventory_System.POSlbl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.keyButton4 = new PetvetPOS_Inventory_System.KeyButton();
            this.label9 = new System.Windows.Forms.Label();
            this.keyButton3 = new PetvetPOS_Inventory_System.KeyButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.keyButton1 = new PetvetPOS_Inventory_System.KeyButton();
            this.label7 = new System.Windows.Forms.Label();
            this.keyButton2 = new PetvetPOS_Inventory_System.KeyButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgTransaction = new System.Windows.Forms.DataGridView();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).BeginInit();
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
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(351, 153);
            this.panel11.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel10.Controls.Add(this.txtQuantity);
            this.panel10.Controls.Add(this.btnQuantity);
            this.panel10.Location = new System.Drawing.Point(167, 55);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(161, 30);
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
            this.txtQuantity.Size = new System.Drawing.Size(157, 26);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextChanged += new System.EventHandler(this.filterNumeric);
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            // 
            // btnQuantity
            // 
            this.btnQuantity.Location = new System.Drawing.Point(20, 4);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(75, 23);
            this.btnQuantity.TabIndex = 1;
            this.btnQuantity.Text = "button1";
            this.btnQuantity.UseVisualStyleBackColor = true;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ORDER #";
            // 
            // lblTransactionno
            // 
            this.lblTransactionno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransactionno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionno.Location = new System.Drawing.Point(154, 23);
            this.lblTransactionno.Name = "lblTransactionno";
            this.lblTransactionno.Size = new System.Drawing.Size(191, 23);
            this.lblTransactionno.TabIndex = 3;
            this.lblTransactionno.Text = "0";
            this.lblTransactionno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "QUANTITY";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txtEncode);
            this.panel3.Location = new System.Drawing.Point(169, 91);
            this.panel3.Location = new System.Drawing.Point(154, 89);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(159, 30);
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
            this.txtEncode.Size = new System.Drawing.Size(155, 26);
            this.txtEncode.TabIndex = 2;
            this.txtEncode.EnabledChanged += new System.EventHandler(this.txtEncode_EnabledChanged);
            this.txtEncode.TextChanged += new System.EventHandler(this.filterAplhaNumeric);
            this.txtEncode.Enter += new System.EventHandler(this.txtEncode_Enter);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRODUCT CODE";
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEncode.BackColor = System.Drawing.Color.White;
            this.btnEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Location = new System.Drawing.Point(167, 91);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(125, 23);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "OK";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPOSmsg);
            this.panel2.Controls.Add(this.poSlbl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(351, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(381, 153);
            this.panel2.TabIndex = 4;
            // 
            // lblPOSmsg
            // 
            this.lblPOSmsg.BackColor = System.Drawing.Color.Black;
            this.lblPOSmsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPOSmsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPOSmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSmsg.ForeColor = System.Drawing.Color.Red;
            this.lblPOSmsg.Location = new System.Drawing.Point(10, 10);
            this.lblPOSmsg.Name = "lblPOSmsg";
            this.lblPOSmsg.Size = new System.Drawing.Size(361, 87);
            this.lblPOSmsg.TabIndex = 14;
            this.lblPOSmsg.Text = "No Transaction";
            this.lblPOSmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poSlbl2
            // 
            this.poSlbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.poSlbl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.poSlbl2.Location = new System.Drawing.Point(10, 97);
            this.poSlbl2.Name = "poSlbl2";
            this.poSlbl2.Size = new System.Drawing.Size(361, 46);
            this.poSlbl2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 515);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 59);
            this.panel4.TabIndex = 44;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.keyButton4);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.keyButton3);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(335, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(393, 55);
            this.panel8.TabIndex = 2;
            // 
            // keyButton4
            // 
            this.keyButton4.accessKeyChar = "F4";
            this.keyButton4.accessMasterController = null;
            this.keyButton4.BackColor = System.Drawing.Color.Transparent;
            this.keyButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton4.Location = new System.Drawing.Point(207, 2);
            this.keyButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton4.Name = "keyButton4";
            this.keyButton4.Size = new System.Drawing.Size(61, 50);
            this.keyButton4.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 18);
            this.label9.TabIndex = 51;
            this.label9.Text = "Cancel Order";
            // 
            // keyButton3
            // 
            this.keyButton3.accessKeyChar = "F3";
            this.keyButton3.accessMasterController = null;
            this.keyButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.keyButton3.BackColor = System.Drawing.Color.Transparent;
            this.keyButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton3.Location = new System.Drawing.Point(14, 2);
            this.keyButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton3.Name = "keyButton3";
            this.keyButton3.Size = new System.Drawing.Size(62, 50);
            this.keyButton3.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(273, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 52;
            this.label10.Text = "Remove Item";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.keyButton1);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.keyButton2);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(728, 55);
            this.panel6.TabIndex = 0;
            // 
            // keyButton1
            // 
            this.keyButton1.accessKeyChar = "F1";
            this.keyButton1.accessMasterController = null;
            this.keyButton1.BackColor = System.Drawing.Color.Transparent;
            this.keyButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton1.Location = new System.Drawing.Point(13, 2);
            this.keyButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton1.Name = "keyButton1";
            this.keyButton1.Size = new System.Drawing.Size(61, 50);
            this.keyButton1.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Start";
            // 
            // keyButton2
            // 
            this.keyButton2.accessKeyChar = "F2";
            this.keyButton2.accessMasterController = null;
            this.keyButton2.BackColor = System.Drawing.Color.Transparent;
            this.keyButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton2.Location = new System.Drawing.Point(194, 2);
            this.keyButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton2.Name = "keyButton2";
            this.keyButton2.Size = new System.Drawing.Size(61, 50);
            this.keyButton2.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Settle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 153);
            this.panel1.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgTransaction);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 153);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(732, 362);
            this.panel5.TabIndex = 46;
            // 
            // dgTransaction
            // 
            this.dgTransaction.AllowUserToAddRows = false;
            this.dgTransaction.AllowUserToDeleteRows = false;
            this.dgTransaction.AllowUserToResizeColumns = false;
            this.dgTransaction.AllowUserToResizeRows = false;
            this.dgTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dgTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransaction.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTransaction.Location = new System.Drawing.Point(20, 20);
            this.dgTransaction.MultiSelect = false;
            this.dgTransaction.Name = "dgTransaction";
            this.dgTransaction.ReadOnly = true;
            this.dgTransaction.RowHeadersVisible = false;
            this.dgTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransaction.Size = new System.Drawing.Size(692, 322);
            this.dgTransaction.TabIndex = 46;
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "OrdersView";
            this.Size = new System.Drawing.Size(732, 574);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).EndInit();
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
        private POSlbl poSlbl2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPOSmsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgTransaction;
        private KeyButton keyButton4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private KeyButton keyButton3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private KeyButton keyButton2;
        private System.Windows.Forms.Panel panel6;
        private KeyButton keyButton1;
        private System.Windows.Forms.Label label7;
    }
}
