namespace PetvetPOS_Inventory_System
{
    partial class AddServices
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMedical = new System.Windows.Forms.RadioButton();
            this.Close = new System.Windows.Forms.Label();
            this.rbGrooming = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.rbMedical);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.rbGrooming);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 28);
            this.panel1.TabIndex = 11;
            // 
            // rbMedical
            // 
            this.rbMedical.AutoSize = true;
            this.rbMedical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMedical.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedical.ForeColor = System.Drawing.Color.White;
            this.rbMedical.Location = new System.Drawing.Point(144, 2);
            this.rbMedical.Name = "rbMedical";
            this.rbMedical.Size = new System.Drawing.Size(101, 22);
            this.rbMedical.TabIndex = 1;
            this.rbMedical.TabStop = true;
            this.rbMedical.Text = "MEDICAL";
            this.rbMedical.UseVisualStyleBackColor = true;
            this.rbMedical.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Close.Location = new System.Drawing.Point(455, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(28, 28);
            this.Close.TabIndex = 10;
            this.Close.Text = "X";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.Click += new System.EventHandler(this.label5_Click);
            // 
            // rbGrooming
            // 
            this.rbGrooming.AutoSize = true;
            this.rbGrooming.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGrooming.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrooming.ForeColor = System.Drawing.Color.White;
            this.rbGrooming.Location = new System.Drawing.Point(11, 2);
            this.rbGrooming.Name = "rbGrooming";
            this.rbGrooming.Size = new System.Drawing.Size(120, 22);
            this.rbGrooming.TabIndex = 0;
            this.rbGrooming.TabStop = true;
            this.rbGrooming.Text = "GROOMING";
            this.rbGrooming.UseVisualStyleBackColor = true;
            this.rbGrooming.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPrice.Location = new System.Drawing.Point(62, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(95, 26);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.TextChanged += new System.EventHandler(this.textChanged);
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            // 
            // cbService
            // 
            this.cbService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(86, 5);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(100, 27);
            this.cbService.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "SERVICE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "SIZE:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSize
            // 
            this.cbSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSize.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "SMALL",
            "MEDIUM",
            "LARGE"});
            this.cbSize.Location = new System.Drawing.Point(62, 5);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(95, 27);
            this.cbSize.TabIndex = 3;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "PRICE:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "DISCOUNT(%)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscount.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDiscount.Location = new System.Drawing.Point(122, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(64, 26);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.textChanged);
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel6);
            this.leftPanel.Controls.Add(this.panel5);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 28);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(191, 74);
            this.leftPanel.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDiscount);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 36);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel6.Size = new System.Drawing.Size(191, 38);
            this.panel6.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbService);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel5.Size = new System.Drawing.Size(191, 34);
            this.panel5.TabIndex = 18;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panel3);
            this.panelRight.Controls.Add(this.panel2);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(353, 28);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(130, 74);
            this.panelRight.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel3.Size = new System.Drawing.Size(130, 35);
            this.panel3.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubtotal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSubtotal.Location = new System.Drawing.Point(68, 5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(57, 26);
            this.txtSubtotal.TabIndex = 7;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "TOTAL:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel2.Size = new System.Drawing.Size(130, 36);
            this.panel2.TabIndex = 0;
            // 
            // txtQty
            // 
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQty.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtQty.Location = new System.Drawing.Point(68, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(57, 26);
            this.txtQty.TabIndex = 4;
            this.txtQty.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "QTY:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.panel8);
            this.middlePanel.Controls.Add(this.panel7);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(191, 28);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(162, 74);
            this.middlePanel.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPrice);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 37);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel8.Size = new System.Drawing.Size(162, 37);
            this.panel8.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbSize);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.btnOK);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.panel7.Size = new System.Drawing.Size(162, 34);
            this.panel7.TabIndex = 15;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(68, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "button1";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // AddServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(157)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AddServices";
            this.Size = new System.Drawing.Size(483, 102);
            this.Load += new System.EventHandler(this.AddServices_Load);
            this.Resize += new System.EventHandler(this.AddServices_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbGrooming;
        private System.Windows.Forms.RadioButton rbMedical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
    }
}
