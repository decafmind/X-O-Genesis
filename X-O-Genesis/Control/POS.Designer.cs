namespace PetvetPOS_Inventory_System
{
    partial class POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.barcodeIndicator = new System.Windows.Forms.Timer(this.components);
            this.paymentTimer = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgTransaction = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.clickIndicator2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.clickIndicator1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPOSmsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.poSlbl2 = new PetvetPOS_Inventory_System.POSlbl();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.keyButton1 = new PetvetPOS_Inventory_System.KeyButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keyButton4 = new PetvetPOS_Inventory_System.KeyButton();
            this.label8 = new System.Windows.Forms.Label();
            this.keyButton3 = new PetvetPOS_Inventory_System.KeyButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.keyButton2 = new PetvetPOS_Inventory_System.KeyButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeIndicator
            // 
            this.barcodeIndicator.Tick += new System.EventHandler(this.barcodeIndicator_Tick);
            // 
            // paymentTimer
            // 
            this.paymentTimer.Interval = 2000;
            this.paymentTimer.Tick += new System.EventHandler(this.paymentTimer_Tick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.dgTransaction);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.shapeContainer1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 160);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(877, 359);
            this.panel6.TabIndex = 3;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // dgTransaction
            // 
            this.dgTransaction.AllowUserToDeleteRows = false;
            this.dgTransaction.AllowUserToOrderColumns = true;
            this.dgTransaction.AllowUserToResizeColumns = false;
            this.dgTransaction.AllowUserToResizeRows = false;
            this.dgTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTransaction.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.dgTransaction.Location = new System.Drawing.Point(10, 10);
            this.dgTransaction.MultiSelect = false;
            this.dgTransaction.Name = "dgTransaction";
            this.dgTransaction.ReadOnly = true;
            this.dgTransaction.RowHeadersVisible = false;
            this.dgTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransaction.Size = new System.Drawing.Size(857, 247);
            this.dgTransaction.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 257);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(857, 92);
            this.panel8.TabIndex = 2;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.txtPayment);
            this.panel9.Controls.Add(this.lblChange);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.btnPayment);
            this.panel9.Controls.Add(this.shapeContainer2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(413, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(444, 92);
            this.panel9.TabIndex = 6;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(137, 13);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayment.Size = new System.Drawing.Size(121, 26);
            this.txtPayment.TabIndex = 4;
            this.txtPayment.TextAlignChanged += new System.EventHandler(this.textChanged);
            this.txtPayment.EnabledChanged += new System.EventHandler(this.txtPayment_EnabledChanged);
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            this.txtPayment.Enter += new System.EventHandler(this.txtPayment_Enter);
            // 
            // lblChange
            // 
            this.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(137, 48);
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblChange.Size = new System.Drawing.Size(121, 23);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cash Tendered:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Change:";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(161, 16);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 6;
            this.btnPayment.Text = "button1";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.clickIndicator2,
            this.clickIndicator1});
            this.shapeContainer2.Size = new System.Drawing.Size(444, 92);
            this.shapeContainer2.TabIndex = 7;
            this.shapeContainer2.TabStop = false;
            // 
            // clickIndicator2
            // 
            this.clickIndicator2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.clickIndicator2.BorderColor = System.Drawing.Color.White;
            this.clickIndicator2.Location = new System.Drawing.Point(307, 18);
            this.clickIndicator2.Name = "clickIndicator2";
            this.clickIndicator2.Size = new System.Drawing.Size(16, 16);
            this.clickIndicator2.Click += new System.EventHandler(this.clickIndicator2_Click);
            // 
            // clickIndicator1
            // 
            this.clickIndicator1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.clickIndicator1.BorderColor = System.Drawing.Color.White;
            this.clickIndicator1.Location = new System.Drawing.Point(281, 18);
            this.clickIndicator1.Name = "clickIndicator1";
            this.clickIndicator1.Size = new System.Drawing.Size(16, 16);
            this.clickIndicator1.Click += new System.EventHandler(this.clickIndicator1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(10, 10);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(857, 339);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(-6, 217);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(5, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(877, 160);
            this.panel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel7);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.panel5);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.btnEncode);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(10, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(409, 160);
            this.panel11.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.txtAddress);
            this.panel7.Location = new System.Drawing.Point(165, 78);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(233, 76);
            this.panel7.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(2, 2);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(229, 72);
            this.txtAddress.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ADDRESS:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Location = new System.Drawing.Point(165, 44);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(233, 30);
            this.panel5.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(2, 2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 26);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUSTOMER NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ORDER #";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txtEncode);
            this.panel3.Location = new System.Drawing.Point(165, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(233, 30);
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
            this.txtEncode.Size = new System.Drawing.Size(229, 26);
            this.txtEncode.TabIndex = 1;
            this.txtEncode.EnabledChanged += new System.EventHandler(this.txtEncode_EnabledChanged);
            this.txtEncode.TextChanged += new System.EventHandler(this.filterAplhaNumeric);
            this.txtEncode.Enter += new System.EventHandler(this.txtEncode_Enter);
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.White;
            this.btnEncode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncode.BackgroundImage")));
            this.btnEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncode.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Location = new System.Drawing.Point(112, 10);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(49, 30);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.lblPOSmsg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.poSlbl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(419, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 160);
            this.panel2.TabIndex = 1;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDiscount.Location = new System.Drawing.Point(8, 70);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(233, 31);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "***Discounted***";
            this.lblDiscount.Visible = false;
            // 
            // lblPOSmsg
            // 
            this.lblPOSmsg.BackColor = System.Drawing.Color.Black;
            this.lblPOSmsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPOSmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOSmsg.ForeColor = System.Drawing.Color.Red;
            this.lblPOSmsg.Location = new System.Drawing.Point(9, 9);
            this.lblPOSmsg.Name = "lblPOSmsg";
            this.lblPOSmsg.Size = new System.Drawing.Size(446, 46);
            this.lblPOSmsg.TabIndex = 12;
            this.lblPOSmsg.Text = "No current transaction";
            this.lblPOSmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount";
            // 
            // poSlbl2
            // 
            this.poSlbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.poSlbl2.Location = new System.Drawing.Point(13, 104);
            this.poSlbl2.Name = "poSlbl2";
            this.poSlbl2.Size = new System.Drawing.Size(435, 46);
            this.poSlbl2.TabIndex = 13;
            this.poSlbl2.Load += new System.EventHandler(this.poSlbl2_Load);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Controls.Add(this.panel4);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel.Location = new System.Drawing.Point(0, 519);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.sidePanel.Size = new System.Drawing.Size(877, 64);
            this.sidePanel.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.keyButton1);
            this.panel4.Controls.Add(this.keyButton4);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.keyButton3);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.keyButton2);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(867, 59);
            this.panel4.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(129, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Start";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(691, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 45);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // keyButton1
            // 
            this.keyButton1.accessKeyChar = "F1";
            this.keyButton1.accessMasterController = null;
            this.keyButton1.BackColor = System.Drawing.Color.Transparent;
            this.keyButton1.dbController = null;
            this.keyButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton1.Location = new System.Drawing.Point(5, 4);
            this.keyButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton1.masterController = null;
            this.keyButton1.Name = "keyButton1";
            this.keyButton1.Size = new System.Drawing.Size(61, 50);
            this.keyButton1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(69, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 45);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // keyButton4
            // 
            this.keyButton4.accessKeyChar = "F4";
            this.keyButton4.accessMasterController = null;
            this.keyButton4.BackColor = System.Drawing.Color.Transparent;
            this.keyButton4.dbController = null;
            this.keyButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton4.Location = new System.Drawing.Point(626, 4);
            this.keyButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton4.masterController = null;
            this.keyButton4.Name = "keyButton4";
            this.keyButton4.Size = new System.Drawing.Size(61, 50);
            this.keyButton4.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(323, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Payment";
            // 
            // keyButton3
            // 
            this.keyButton3.accessKeyChar = "F3";
            this.keyButton3.accessMasterController = null;
            this.keyButton3.BackColor = System.Drawing.Color.Transparent;
            this.keyButton3.dbController = null;
            this.keyButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton3.Location = new System.Drawing.Point(426, 4);
            this.keyButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton3.masterController = null;
            this.keyButton3.Name = "keyButton3";
            this.keyButton3.Size = new System.Drawing.Size(61, 50);
            this.keyButton3.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(751, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Void Product";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(261, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 45);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // keyButton2
            // 
            this.keyButton2.accessKeyChar = "F2";
            this.keyButton2.accessMasterController = null;
            this.keyButton2.BackColor = System.Drawing.Color.Transparent;
            this.keyButton2.dbController = null;
            this.keyButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton2.Location = new System.Drawing.Point(197, 7);
            this.keyButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton2.masterController = null;
            this.keyButton2.Name = "keyButton2";
            this.keyButton2.Size = new System.Drawing.Size(61, 50);
            this.keyButton2.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.Refresh;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(487, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 45);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(547, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Reset";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePanel);
            this.Name = "POS";
            this.Size = new System.Drawing.Size(877, 583);
            this.Load += new System.EventHandler(this.POS_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private POSlbl poSlbl2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgTransaction;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KeyButton keyButton4;
        private KeyButton keyButton3;
        private KeyButton keyButton2;
        private KeyButton keyButton1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer barcodeIndicator;
        private System.Windows.Forms.Timer paymentTimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnPayment;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape clickIndicator2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape clickIndicator1;
        private System.Windows.Forms.Label lblPOSmsg;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblDiscount;

    }
}
