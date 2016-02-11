namespace PetvetPOS_Inventory_System
{
    partial class OrderPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPOS));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.barcodeIndicator = new System.Windows.Forms.Timer(this.components);
            this.paymentTimer = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgTransaction = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnEncode = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransactionno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
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
            // paymentTimer
            // 
            this.paymentTimer.Interval = 2000;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.dgTransaction);
            this.panel6.Controls.Add(this.shapeContainer1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 169);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(877, 350);
            this.panel6.TabIndex = 6;
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
            this.dgTransaction.Size = new System.Drawing.Size(857, 330);
            this.dgTransaction.TabIndex = 3;
            this.dgTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransaction_CellContentClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(10, 10);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(857, 330);
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
            this.panel1.Size = new System.Drawing.Size(877, 169);
            this.panel1.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnEncode);
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.lblTransactionno);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(10, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(409, 169);
            this.panel11.TabIndex = 2;
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.White;
            this.btnEncode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEncode.BackgroundImage")));
            this.btnEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Location = new System.Drawing.Point(184, 65);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(49, 30);
            this.btnEncode.TabIndex = 12;
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel10.Controls.Add(this.txtQuantity);
            this.panel10.Controls.Add(this.btnQuantity);
            this.panel10.Location = new System.Drawing.Point(178, 111);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(220, 34);
            this.panel10.TabIndex = 11;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(2, 2);
            this.txtQuantity.MaxLength = 20;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(216, 30);
            this.txtQuantity.TabIndex = 1;
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
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txtEncode);
            this.panel3.Location = new System.Drawing.Point(239, 63);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(159, 35);
            this.panel3.TabIndex = 8;
            // 
            // txtEncode
            // 
            this.txtEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncode.Enabled = false;
            this.txtEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncode.Location = new System.Drawing.Point(2, 2);
            this.txtEncode.MaxLength = 20;
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(155, 30);
            this.txtEncode.TabIndex = 2;
            this.txtEncode.Enter += new System.EventHandler(this.txtEncode_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "QUANTITY";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(8, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "PRODUCT CODE";
            // 
            // lblTransactionno
            // 
            this.lblTransactionno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransactionno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionno.Location = new System.Drawing.Point(184, 13);
            this.lblTransactionno.Name = "lblTransactionno";
            this.lblTransactionno.Size = new System.Drawing.Size(191, 28);
            this.lblTransactionno.TabIndex = 7;
            this.lblTransactionno.Text = "0";
            this.lblTransactionno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ORDER #";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPOSmsg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.poSlbl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(419, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 169);
            this.panel2.TabIndex = 1;
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
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidePanel.Controls.Add(this.panel4);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel.Location = new System.Drawing.Point(0, 519);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.sidePanel.Size = new System.Drawing.Size(877, 64);
            this.sidePanel.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.keyButton1);
            this.panel4.Controls.Add(this.pictureBox1);
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
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
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
            this.pictureBox4.Location = new System.Drawing.Point(634, 6);
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
            this.keyButton1.Location = new System.Drawing.Point(66, 6);
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
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
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
            this.keyButton4.Location = new System.Drawing.Point(693, 4);
            this.keyButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton4.masterController = null;
            this.keyButton4.Name = "keyButton4";
            this.keyButton4.Size = new System.Drawing.Size(61, 50);
            this.keyButton4.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
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
            this.keyButton3.Location = new System.Drawing.Point(479, 6);
            this.keyButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton3.masterController = null;
            this.keyButton3.Name = "keyButton3";
            this.keyButton3.Size = new System.Drawing.Size(61, 50);
            this.keyButton3.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label10.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Location = new System.Drawing.Point(751, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Void Product";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.payment;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(201, 6);
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
            this.keyButton2.Location = new System.Drawing.Point(260, 6);
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
            this.pictureBox3.Location = new System.Drawing.Point(419, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 45);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(544, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Reset";
            // 
            // OrderPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePanel);
            this.Name = "OrderPOS";
            this.Size = new System.Drawing.Size(877, 583);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
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

        private System.Windows.Forms.Label lblPOSmsg;
        private System.Windows.Forms.Label label1;
        private POSlbl poSlbl2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private KeyButton keyButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KeyButton keyButton4;
        private System.Windows.Forms.Label label8;
        private KeyButton keyButton3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private KeyButton keyButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgTransaction;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer barcodeIndicator;
        private System.Windows.Forms.Timer paymentTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblTransactionno;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEncode;
    }
}
