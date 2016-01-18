namespace PetvetPOS_Inventory_System
{
    partial class ServiceScrollPane
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
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbMedical = new System.Windows.Forms.RadioButton();
            this.rbGrooming = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbStayput = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "SMALL",
            "MEDIUM",
            "LARGE"});
            this.cbSize.Location = new System.Drawing.Point(85, 157);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(146, 27);
            this.cbSize.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "PETSIZE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRICE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "NAME:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(85, 192);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(146, 26);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(85, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 26);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtChanged);
            // 
            // rbMedical
            // 
            this.rbMedical.AutoSize = true;
            this.rbMedical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedical.Location = new System.Drawing.Point(10, 88);
            this.rbMedical.Name = "rbMedical";
            this.rbMedical.Size = new System.Drawing.Size(76, 23);
            this.rbMedical.TabIndex = 2;
            this.rbMedical.TabStop = true;
            this.rbMedical.Text = "Medical";
            this.rbMedical.UseVisualStyleBackColor = true;
            this.rbMedical.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbGrooming
            // 
            this.rbGrooming.AutoSize = true;
            this.rbGrooming.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrooming.Location = new System.Drawing.Point(10, 59);
            this.rbGrooming.Name = "rbGrooming";
            this.rbGrooming.Size = new System.Drawing.Size(87, 23);
            this.rbGrooming.TabIndex = 1;
            this.rbGrooming.TabStop = true;
            this.rbGrooming.Text = "Grooming";
            this.rbGrooming.UseVisualStyleBackColor = true;
            this.rbGrooming.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(158)))), ((int)(((byte)(150)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Services";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbStayput
            // 
            this.cbStayput.AutoSize = true;
            this.cbStayput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStayput.Location = new System.Drawing.Point(14, 227);
            this.cbStayput.Name = "cbStayput";
            this.cbStayput.Size = new System.Drawing.Size(133, 23);
            this.cbStayput.TabIndex = 9;
            this.cbStayput.Text = "Keep from hiding";
            this.cbStayput.UseVisualStyleBackColor = true;
            this.cbStayput.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ServiceScrollPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cbStayput);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rbMedical);
            this.Controls.Add(this.rbGrooming);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ServiceScrollPane";
            this.Size = new System.Drawing.Size(243, 51);
            this.Load += new System.EventHandler(this.ServiceScrollPane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.CheckBox cbStayput;
        public System.Windows.Forms.RadioButton rbGrooming;
        public System.Windows.Forms.RadioButton rbMedical;
    }
}
