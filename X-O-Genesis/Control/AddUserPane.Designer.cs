namespace PetvetPOS_Inventory_System
{
    partial class AddUserPane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserPane));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.vUsername = new PetvetPOS_Inventory_System.ValidationMarks();
            this.vRepassword = new PetvetPOS_Inventory_System.ValidationMarks();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAsterisk3 = new System.Windows.Forms.Label();
            this.lblAsterisk2 = new System.Windows.Forms.Label();
            this.lblAsterisk1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.domainPosition = new System.Windows.Forms.DomainUpDown();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.lblRepassword = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtImagepath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMobno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(416, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 125;
            this.button1.TabStop = false;
            this.toolTip1.SetToolTip(this.button1, "Take picture from webcam");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // upload
            // 
            this.upload.BackColor = System.Drawing.Color.White;
            this.upload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upload.BackgroundImage")));
            this.upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload.Location = new System.Drawing.Point(363, 119);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(47, 23);
            this.upload.TabIndex = 111;
            this.upload.TabStop = false;
            this.toolTip1.SetToolTip(this.upload, "Upload from files");
            this.upload.UseVisualStyleBackColor = false;
            this.upload.Click += new System.EventHandler(this.upload_Click_1);
            // 
            // vUsername
            // 
            this.vUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vUsername.BackgroundImage")));
            this.vUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vUsername.Location = new System.Drawing.Point(404, 307);
            this.vUsername.Name = "vUsername";
            this.vUsername.Size = new System.Drawing.Size(33, 24);
            this.vUsername.TabIndex = 124;
            this.toolTip1.SetToolTip(this.vUsername, "username already exists");
            this.vUsername.Visible = false;
            // 
            // vRepassword
            // 
            this.vRepassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vRepassword.BackgroundImage")));
            this.vRepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vRepassword.Location = new System.Drawing.Point(405, 372);
            this.vRepassword.Name = "vRepassword";
            this.vRepassword.Size = new System.Drawing.Size(33, 24);
            this.vRepassword.TabIndex = 122;
            this.toolTip1.SetToolTip(this.vRepassword, "Password doesn\'t match");
            this.vRepassword.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(182, 192);
            this.textBox2.MaxLength = 13;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 26);
            this.textBox2.TabIndex = 129;
            this.textBox2.TextChanged += new System.EventHandler(this.filterEmail);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 128;
            this.label7.Text = "EMAIL ADDRESS:";
            // 
            // txtTelno
            // 
            this.txtTelno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelno.Location = new System.Drawing.Point(345, 152);
            this.txtTelno.MaxLength = 7;
            this.txtTelno.Name = "txtTelno";
            this.txtTelno.Size = new System.Drawing.Size(118, 26);
            this.txtTelno.TabIndex = 127;
            this.txtTelno.TextChanged += new System.EventHandler(this.filterContacts);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 126;
            this.label4.Text = "TEL NO:";
            // 
            // lblAsterisk3
            // 
            this.lblAsterisk3.AutoSize = true;
            this.lblAsterisk3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk3.Location = new System.Drawing.Point(33, 367);
            this.lblAsterisk3.Name = "lblAsterisk3";
            this.lblAsterisk3.Size = new System.Drawing.Size(15, 17);
            this.lblAsterisk3.TabIndex = 121;
            this.lblAsterisk3.Text = "*";
            // 
            // lblAsterisk2
            // 
            this.lblAsterisk2.AutoSize = true;
            this.lblAsterisk2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk2.Location = new System.Drawing.Point(33, 344);
            this.lblAsterisk2.Name = "lblAsterisk2";
            this.lblAsterisk2.Size = new System.Drawing.Size(15, 17);
            this.lblAsterisk2.TabIndex = 120;
            this.lblAsterisk2.Text = "*";
            // 
            // lblAsterisk1
            // 
            this.lblAsterisk1.AutoSize = true;
            this.lblAsterisk1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisk1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisk1.Location = new System.Drawing.Point(33, 310);
            this.lblAsterisk1.Name = "lblAsterisk1";
            this.lblAsterisk1.Size = new System.Drawing.Size(15, 17);
            this.lblAsterisk1.TabIndex = 119;
            this.lblAsterisk1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 116;
            this.label3.Text = "LAST NAME";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(8, 60);
            this.txtFirstname.MaxLength = 45;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(117, 29);
            this.txtFirstname.TabIndex = 112;
            this.txtFirstname.TextChanged += new System.EventHandler(this.filterNames);
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(131, 60);
            this.txtMiddlename.MaxLength = 45;
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(79, 29);
            this.txtMiddlename.TabIndex = 113;
            this.txtMiddlename.TextChanged += new System.EventHandler(this.filterNames);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "MI";
            // 
            // imageUser
            // 
            this.imageUser.BackColor = System.Drawing.Color.Transparent;
            this.imageUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageUser.InitialImage = null;
            this.imageUser.Location = new System.Drawing.Point(363, 15);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(100, 100);
            this.imageUser.TabIndex = 115;
            this.imageUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 117;
            this.label1.Text = "FIRST NAME";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(216, 60);
            this.txtLastname.MaxLength = 45;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(116, 29);
            this.txtLastname.TabIndex = 114;
            this.txtLastname.TextChanged += new System.EventHandler(this.filterNames);
            // 
            // domainPosition
            // 
            this.domainPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainPosition.Items.Add("Cashier");
            this.domainPosition.Items.Add("Inventory Personnel");
            this.domainPosition.Items.Add("Staff");
            this.domainPosition.Location = new System.Drawing.Point(117, 94);
            this.domainPosition.Name = "domainPosition";
            this.domainPosition.ReadOnly = true;
            this.domainPosition.Size = new System.Drawing.Size(215, 26);
            this.domainPosition.TabIndex = 11;
            this.domainPosition.Text = "Cashier";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepassword.Location = new System.Drawing.Point(182, 372);
            this.txtRepassword.MaxLength = 45;
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(216, 26);
            this.txtRepassword.TabIndex = 16;
            this.txtRepassword.UseSystemPasswordChar = true;
            this.txtRepassword.TextChanged += new System.EventHandler(this.textboxes_TextChanged);
            // 
            // lblRepassword
            // 
            this.lblRepassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepassword.Location = new System.Drawing.Point(54, 366);
            this.lblRepassword.Name = "lblRepassword";
            this.lblRepassword.Size = new System.Drawing.Size(110, 49);
            this.lblRepassword.TabIndex = 110;
            this.lblRepassword.Text = "RETYPE PASSWORD:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(182, 232);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 64);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.TextChanged += new System.EventHandler(this.filterParagraph);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 108;
            this.label9.Text = "ADDRESS:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 27);
            this.panel2.TabIndex = 107;
            // 
            // lblMode
            // 
            this.lblMode.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(0, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(482, 27);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Mode";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(218, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(46, 21);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.TextChanged += new System.EventHandler(this.textboxes_TextChanged);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtImagepath
            // 
            this.txtImagepath.Location = new System.Drawing.Point(397, 419);
            this.txtImagepath.Name = "txtImagepath";
            this.txtImagepath.Size = new System.Drawing.Size(69, 20);
            this.txtImagepath.TabIndex = 17;
            this.txtImagepath.TabStop = false;
            this.txtImagepath.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 105;
            this.label6.Text = "USERNAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 103;
            this.label5.Text = "POSITION:";
            // 
            // txtMobno
            // 
            this.txtMobno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobno.Location = new System.Drawing.Point(136, 152);
            this.txtMobno.MaxLength = 13;
            this.txtMobno.Name = "txtMobno";
            this.txtMobno.Size = new System.Drawing.Size(118, 26);
            this.txtMobno.TabIndex = 12;
            this.txtMobno.TextChanged += new System.EventHandler(this.filterContacts);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 104;
            this.label8.Text = "MOBILE NO:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(182, 307);
            this.txtUsername.MaxLength = 45;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(216, 26);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.TextChanged += new System.EventHandler(this.textboxes_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(182, 340);
            this.txtPassword.MaxLength = 45;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 26);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.textboxes_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(53, 343);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 19);
            this.lblPassword.TabIndex = 106;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // AddUserPane
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vUsername);
            this.Controls.Add(this.vRepassword);
            this.Controls.Add(this.lblAsterisk3);
            this.Controls.Add(this.lblAsterisk2);
            this.Controls.Add(this.lblAsterisk1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.domainPosition);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.lblRepassword);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtImagepath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMobno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "AddUserPane";
            this.Size = new System.Drawing.Size(482, 479);
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMobno;
        private System.Windows.Forms.TextBox txtImagepath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblRepassword;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.DomainUpDown domainPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblAsterisk1;
        private System.Windows.Forms.Label lblAsterisk2;
        private System.Windows.Forms.Label lblAsterisk3;
        private ValidationMarks vRepassword;
        private ValidationMarks vUsername;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox imageUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
    }
}
