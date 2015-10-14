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
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPOSmsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightSidePane = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.poSlbl2 = new PetvetPOS_Inventory_System.POSlbl();
            this.keyButton1 = new PetvetPOS_Inventory_System.KeyButton();
            this.keyButton4 = new PetvetPOS_Inventory_System.KeyButton();
            this.keyButton3 = new PetvetPOS_Inventory_System.KeyButton();
            this.keyButton2 = new PetvetPOS_Inventory_System.KeyButton();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaction)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
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
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.dgTransaction);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.shapeContainer1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 119);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10);
            this.panel6.Size = new System.Drawing.Size(877, 400);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 288);
            this.panel5.TabIndex = 4;
            // 
            // dgTransaction
            // 
            this.dgTransaction.AllowUserToDeleteRows = false;
            this.dgTransaction.AllowUserToOrderColumns = true;
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
            this.dgTransaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgTransaction.Location = new System.Drawing.Point(423, 10);
            this.dgTransaction.MultiSelect = false;
            this.dgTransaction.Name = "dgTransaction";
            this.dgTransaction.ReadOnly = true;
            this.dgTransaction.RowHeadersVisible = false;
            this.dgTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransaction.Size = new System.Drawing.Size(444, 288);
            this.dgTransaction.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 298);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(857, 92);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
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
            this.txtPayment.Location = new System.Drawing.Point(114, 14);
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
            this.lblChange.Location = new System.Drawing.Point(114, 48);
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
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cash tender:";
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
            this.btnPayment.Location = new System.Drawing.Point(129, 16);
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
            this.clickIndicator2.Location = new System.Drawing.Point(277, 19);
            this.clickIndicator2.Name = "clickIndicator2";
            this.clickIndicator2.Size = new System.Drawing.Size(16, 16);
            // 
            // clickIndicator1
            // 
            this.clickIndicator1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.clickIndicator1.BorderColor = System.Drawing.Color.White;
            this.clickIndicator1.Location = new System.Drawing.Point(251, 19);
            this.clickIndicator1.Name = "clickIndicator1";
            this.clickIndicator1.Size = new System.Drawing.Size(16, 16);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(10, 10);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(857, 380);
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
            this.panel1.Controls.Add(this.rightSidePane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(877, 119);
            this.panel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.btnEncode);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(121, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(298, 119);
            this.panel11.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ORDER #";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.txtEncode);
            this.panel3.Location = new System.Drawing.Point(106, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(174, 30);
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
            this.txtEncode.Size = new System.Drawing.Size(170, 26);
            this.txtEncode.TabIndex = 1;
            this.txtEncode.EnabledChanged += new System.EventHandler(this.txtEncode_EnabledChanged);
            this.txtEncode.TextChanged += new System.EventHandler(this.textChanged);
            this.txtEncode.Enter += new System.EventHandler(this.txtEncode_Enter);
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.White;
            this.btnEncode.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.barcodeSearch;
            this.btnEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
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
            this.panel2.Controls.Add(this.lblPOSmsg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.poSlbl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(419, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 119);
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
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Amount";
            // 
            // rightSidePane
            // 
            this.rightSidePane.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.barcodeWhite;
            this.rightSidePane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightSidePane.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightSidePane.Location = new System.Drawing.Point(10, 0);
            this.rightSidePane.Name = "rightSidePane";
            this.rightSidePane.Padding = new System.Windows.Forms.Padding(10);
            this.rightSidePane.Size = new System.Drawing.Size(111, 119);
            this.rightSidePane.TabIndex = 2;
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
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pictureBox4.Location = new System.Drawing.Point(685, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 42);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(65, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 42);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(323, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Payment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(751, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Void Product";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(257, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 42);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(478, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 42);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(544, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Reset";
            // 
            // poSlbl2
            // 
            this.poSlbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.poSlbl2.Location = new System.Drawing.Point(182, 61);
            this.poSlbl2.Name = "poSlbl2";
            this.poSlbl2.Size = new System.Drawing.Size(273, 46);
            this.poSlbl2.TabIndex = 13;
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
            this.keyButton4.Location = new System.Drawing.Point(621, 7);
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
            this.keyButton3.Location = new System.Drawing.Point(416, 6);
            this.keyButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton3.Name = "keyButton3";
            this.keyButton3.Size = new System.Drawing.Size(61, 50);
            this.keyButton3.TabIndex = 18;
            // 
            // keyButton2
            // 
            this.keyButton2.accessKeyChar = "F2";
            this.keyButton2.accessMasterController = null;
            this.keyButton2.BackColor = System.Drawing.Color.Transparent;
            this.keyButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.keyButton2.Location = new System.Drawing.Point(196, 5);
            this.keyButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.keyButton2.Name = "keyButton2";
            this.keyButton2.Size = new System.Drawing.Size(61, 50);
            this.keyButton2.TabIndex = 17;
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
        private System.Windows.Forms.Panel rightSidePane;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgTransaction;
        private System.Windows.Forms.Button btnEncode;
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
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnPayment;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape clickIndicator2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape clickIndicator1;
        private System.Windows.Forms.Label lblPOSmsg;
        private System.Windows.Forms.Panel panel5;

    }
}
