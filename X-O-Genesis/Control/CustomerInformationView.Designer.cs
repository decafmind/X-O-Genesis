namespace PetvetPOS_Inventory_System
{
    partial class CustomerInformationView
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
            this.customerInfo_panel = new System.Windows.Forms.Panel();
            this.updateContacts_panel = new System.Windows.Forms.Panel();
            this.btnDiscardUpdate = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.txtUpdateOtherContacts = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUpdateMobile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newClient_tab = new System.Windows.Forms.TabPage();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtLandline = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.existingClient_tab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditContacts = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgExistingClients = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.orderSliderPane1 = new PetvetPOS_Inventory_System.OrderSliderPane();
            this.customerInfo_panel.SuspendLayout();
            this.updateContacts_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.newClient_tab.SuspendLayout();
            this.existingClient_tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExistingClients)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInfo_panel
            // 
            this.customerInfo_panel.BackColor = System.Drawing.Color.White;
            this.customerInfo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerInfo_panel.Controls.Add(this.updateContacts_panel);
            this.customerInfo_panel.Controls.Add(this.tabControl1);
            this.customerInfo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerInfo_panel.Location = new System.Drawing.Point(0, 0);
            this.customerInfo_panel.Name = "customerInfo_panel";
            this.customerInfo_panel.Size = new System.Drawing.Size(840, 583);
            this.customerInfo_panel.TabIndex = 0;
            this.customerInfo_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // updateContacts_panel
            // 
            this.updateContacts_panel.Controls.Add(this.btnDiscardUpdate);
            this.updateContacts_panel.Controls.Add(this.btnSaveUpdate);
            this.updateContacts_panel.Controls.Add(this.txtUpdateOtherContacts);
            this.updateContacts_panel.Controls.Add(this.label14);
            this.updateContacts_panel.Controls.Add(this.txtUpdateMobile);
            this.updateContacts_panel.Controls.Add(this.label13);
            this.updateContacts_panel.Location = new System.Drawing.Point(556, 3);
            this.updateContacts_panel.Name = "updateContacts_panel";
            this.updateContacts_panel.Size = new System.Drawing.Size(279, 576);
            this.updateContacts_panel.TabIndex = 2;
            // 
            // btnDiscardUpdate
            // 
            this.btnDiscardUpdate.Location = new System.Drawing.Point(165, 332);
            this.btnDiscardUpdate.Name = "btnDiscardUpdate";
            this.btnDiscardUpdate.Size = new System.Drawing.Size(100, 82);
            this.btnDiscardUpdate.TabIndex = 50;
            this.btnDiscardUpdate.Text = "Cancel";
            this.btnDiscardUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(17, 332);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(100, 82);
            this.btnSaveUpdate.TabIndex = 49;
            this.btnSaveUpdate.Text = "Save";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // txtUpdateOtherContacts
            // 
            this.txtUpdateOtherContacts.Location = new System.Drawing.Point(17, 280);
            this.txtUpdateOtherContacts.Name = "txtUpdateOtherContacts";
            this.txtUpdateOtherContacts.Size = new System.Drawing.Size(248, 20);
            this.txtUpdateOtherContacts.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Other Contact:";
            // 
            // txtUpdateMobile
            // 
            this.txtUpdateMobile.Location = new System.Drawing.Point(17, 195);
            this.txtUpdateMobile.Name = "txtUpdateMobile";
            this.txtUpdateMobile.Size = new System.Drawing.Size(248, 20);
            this.txtUpdateMobile.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Mobile No:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.newClient_tab);
            this.tabControl1.Controls.Add(this.existingClient_tab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 583);
            this.tabControl1.TabIndex = 1;
            // 
            // newClient_tab
            // 
            this.newClient_tab.Controls.Add(this.btnDiscard);
            this.newClient_tab.Controls.Add(this.btnSave);
            this.newClient_tab.Controls.Add(this.txtEmail);
            this.newClient_tab.Controls.Add(this.txtMobile);
            this.newClient_tab.Controls.Add(this.txtLandline);
            this.newClient_tab.Controls.Add(this.txtAdd2);
            this.newClient_tab.Controls.Add(this.txtAdd1);
            this.newClient_tab.Controls.Add(this.txtMname);
            this.newClient_tab.Controls.Add(this.txtFname);
            this.newClient_tab.Controls.Add(this.txtLname);
            this.newClient_tab.Controls.Add(this.label9);
            this.newClient_tab.Controls.Add(this.label8);
            this.newClient_tab.Controls.Add(this.label7);
            this.newClient_tab.Controls.Add(this.label6);
            this.newClient_tab.Controls.Add(this.label5);
            this.newClient_tab.Controls.Add(this.label4);
            this.newClient_tab.Controls.Add(this.label3);
            this.newClient_tab.Controls.Add(this.label2);
            this.newClient_tab.Controls.Add(this.label1);
            this.newClient_tab.Location = new System.Drawing.Point(4, 22);
            this.newClient_tab.Name = "newClient_tab";
            this.newClient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.newClient_tab.Size = new System.Drawing.Size(546, 557);
            this.newClient_tab.TabIndex = 0;
            this.newClient_tab.Text = "New Client";
            this.newClient_tab.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(315, 457);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(177, 55);
            this.btnDiscard.TabIndex = 44;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 55);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 386);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 20);
            this.txtEmail.TabIndex = 41;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(130, 320);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(118, 20);
            this.txtMobile.TabIndex = 40;
            // 
            // txtLandline
            // 
            this.txtLandline.Location = new System.Drawing.Point(392, 320);
            this.txtLandline.Name = "txtLandline";
            this.txtLandline.Size = new System.Drawing.Size(118, 20);
            this.txtLandline.TabIndex = 39;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(130, 264);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(380, 20);
            this.txtAdd2.TabIndex = 38;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(130, 203);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(380, 20);
            this.txtAdd1.TabIndex = 37;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(392, 133);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(118, 20);
            this.txtMname.TabIndex = 36;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(219, 133);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(118, 20);
            this.txtFname.TabIndex = 35;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(34, 133);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(118, 20);
            this.txtLname.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "E-mail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mobile No.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Other Contact No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Address Line 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address Line 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Client Information:";
            // 
            // existingClient_tab
            // 
            this.existingClient_tab.Controls.Add(this.panel2);
            this.existingClient_tab.Controls.Add(this.panel1);
            this.existingClient_tab.Location = new System.Drawing.Point(4, 22);
            this.existingClient_tab.Name = "existingClient_tab";
            this.existingClient_tab.Padding = new System.Windows.Forms.Padding(3);
            this.existingClient_tab.Size = new System.Drawing.Size(546, 557);
            this.existingClient_tab.TabIndex = 1;
            this.existingClient_tab.Text = "Existing Client";
            this.existingClient_tab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnEditContacts);
            this.panel2.Controls.Add(this.btnNewOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(332, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 551);
            this.panel2.TabIndex = 48;
            // 
            // btnEditContacts
            // 
            this.btnEditContacts.Location = new System.Drawing.Point(42, 266);
            this.btnEditContacts.Name = "btnEditContacts";
            this.btnEditContacts.Size = new System.Drawing.Size(139, 82);
            this.btnEditContacts.TabIndex = 42;
            this.btnEditContacts.Text = "Edit Contacts";
            this.btnEditContacts.UseVisualStyleBackColor = true;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(42, 101);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(139, 82);
            this.btnNewOrder.TabIndex = 41;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 551);
            this.panel1.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgExistingClients);
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20);
            this.panel4.Size = new System.Drawing.Size(331, 454);
            this.panel4.TabIndex = 47;
            // 
            // dgExistingClients
            // 
            this.dgExistingClients.AllowUserToAddRows = false;
            this.dgExistingClients.AllowUserToDeleteRows = false;
            this.dgExistingClients.AllowUserToResizeColumns = false;
            this.dgExistingClients.AllowUserToResizeRows = false;
            this.dgExistingClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExistingClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgExistingClients.BackgroundColor = System.Drawing.Color.White;
            this.dgExistingClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgExistingClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExistingClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgExistingClients.Location = new System.Drawing.Point(20, 20);
            this.dgExistingClients.MultiSelect = false;
            this.dgExistingClients.Name = "dgExistingClients";
            this.dgExistingClients.ReadOnly = true;
            this.dgExistingClients.RowHeadersVisible = false;
            this.dgExistingClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExistingClients.Size = new System.Drawing.Size(291, 414);
            this.dgExistingClients.TabIndex = 0;
            this.dgExistingClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgExistingClients_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtClientName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 97);
            this.panel3.TabIndex = 46;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(20, 41);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(286, 20);
            this.txtClientName.TabIndex = 44;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(17, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Search By Name:";
            // 
            // orderSliderPane1
            // 
            this.orderSliderPane1.accessMasterController = null;
            this.orderSliderPane1.BackColor = System.Drawing.Color.White;
            this.orderSliderPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.orderSliderPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.orderSliderPane1.Location = new System.Drawing.Point(840, 0);
            this.orderSliderPane1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.orderSliderPane1.MinimumSize = new System.Drawing.Size(30, 600);
            this.orderSliderPane1.Name = "orderSliderPane1";
            this.orderSliderPane1.Size = new System.Drawing.Size(30, 600);
            this.orderSliderPane1.TabIndex = 1;
            // 
            // CustomerInformationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customerInfo_panel);
            this.Controls.Add(this.orderSliderPane1);
            this.Name = "CustomerInformationView";
            this.Size = new System.Drawing.Size(870, 583);
            this.customerInfo_panel.ResumeLayout(false);
            this.updateContacts_panel.ResumeLayout(false);
            this.updateContacts_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.newClient_tab.ResumeLayout(false);
            this.newClient_tab.PerformLayout();
            this.existingClient_tab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgExistingClients)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customerInfo_panel;
        private OrderSliderPane orderSliderPane1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage newClient_tab;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtLandline;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage existingClient_tab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditContacts;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgExistingClients;
        private System.Windows.Forms.Panel updateContacts_panel;
        private System.Windows.Forms.Button btnDiscardUpdate;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.TextBox txtUpdateOtherContacts;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUpdateMobile;
        private System.Windows.Forms.Label label13;
    }
}
