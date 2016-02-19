namespace PetvetPOS_Inventory_System
{
    partial class DiscountsControl
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
            this.panel_Contents = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLess = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.group_Type = new System.Windows.Forms.GroupBox();
            this.radio_Fixed = new System.Windows.Forms.RadioButton();
            this.radio_Percent = new System.Windows.Forms.RadioButton();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Button = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel_List = new System.Windows.Forms.Panel();
            this.lv_Discounts = new System.Windows.Forms.ListView();
            this.panel_Label = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Contents.SuspendLayout();
            this.group_Type.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.panel_List.SuspendLayout();
            this.panel_Label.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Contents
            // 
            this.panel_Contents.Controls.Add(this.btnSave);
            this.panel_Contents.Controls.Add(this.lblStatus);
            this.panel_Contents.Controls.Add(this.txtLess);
            this.panel_Contents.Controls.Add(this.txtDesc);
            this.panel_Contents.Controls.Add(this.group_Type);
            this.panel_Contents.Controls.Add(this.txtTitle);
            this.panel_Contents.Controls.Add(this.label5);
            this.panel_Contents.Controls.Add(this.label4);
            this.panel_Contents.Controls.Add(this.label3);
            this.panel_Contents.Controls.Add(this.label2);
            this.panel_Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contents.Location = new System.Drawing.Point(231, 54);
            this.panel_Contents.Name = "panel_Contents";
            this.panel_Contents.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Contents.Size = new System.Drawing.Size(367, 262);
            this.panel_Contents.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(5, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Discounts";
            // 
            // txtLess
            // 
            this.txtLess.Enabled = false;
            this.txtLess.Location = new System.Drawing.Point(98, 224);
            this.txtLess.Name = "txtLess";
            this.txtLess.Size = new System.Drawing.Size(75, 20);
            this.txtLess.TabIndex = 7;
            this.txtLess.TextChanged += new System.EventHandler(this.txtLess_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(98, 141);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(246, 63);
            this.txtDesc.TabIndex = 6;
            // 
            // group_Type
            // 
            this.group_Type.Controls.Add(this.radio_Fixed);
            this.group_Type.Controls.Add(this.radio_Percent);
            this.group_Type.Enabled = false;
            this.group_Type.Location = new System.Drawing.Point(98, 78);
            this.group_Type.Name = "group_Type";
            this.group_Type.Size = new System.Drawing.Size(246, 50);
            this.group_Type.TabIndex = 5;
            this.group_Type.TabStop = false;
            // 
            // radio_Fixed
            // 
            this.radio_Fixed.AutoSize = true;
            this.radio_Fixed.Location = new System.Drawing.Point(142, 17);
            this.radio_Fixed.Name = "radio_Fixed";
            this.radio_Fixed.Size = new System.Drawing.Size(89, 17);
            this.radio_Fixed.TabIndex = 1;
            this.radio_Fixed.TabStop = true;
            this.radio_Fixed.Text = "Fixed Amount";
            this.radio_Fixed.UseVisualStyleBackColor = true;
            // 
            // radio_Percent
            // 
            this.radio_Percent.AutoSize = true;
            this.radio_Percent.Location = new System.Drawing.Point(13, 17);
            this.radio_Percent.Name = "radio_Percent";
            this.radio_Percent.Size = new System.Drawing.Size(33, 17);
            this.radio_Percent.TabIndex = 0;
            this.radio_Percent.TabStop = true;
            this.radio_Percent.Text = "%";
            this.radio_Percent.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(98, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(246, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount Less:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discount Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Discount Type:";
            // 
            // panel_Button
            // 
            this.panel_Button.Controls.Add(this.btnDelete);
            this.panel_Button.Controls.Add(this.btnEdit);
            this.panel_Button.Controls.Add(this.btnAdd);
            this.panel_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Button.Location = new System.Drawing.Point(231, 316);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(367, 71);
            this.panel_Button.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(146, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel_List
            // 
            this.panel_List.Controls.Add(this.lv_Discounts);
            this.panel_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_List.Location = new System.Drawing.Point(0, 54);
            this.panel_List.Name = "panel_List";
            this.panel_List.Padding = new System.Windows.Forms.Padding(5);
            this.panel_List.Size = new System.Drawing.Size(231, 333);
            this.panel_List.TabIndex = 6;
            // 
            // lv_Discounts
            // 
            this.lv_Discounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Discounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lv_Discounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Discounts.Location = new System.Drawing.Point(5, 5);
            this.lv_Discounts.Name = "lv_Discounts";
            this.lv_Discounts.Size = new System.Drawing.Size(221, 323);
            this.lv_Discounts.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lv_Discounts.TabIndex = 0;
            this.lv_Discounts.UseCompatibleStateImageBehavior = false;
            this.lv_Discounts.SelectedIndexChanged += new System.EventHandler(this.lv_Discounts_SelectedIndexChanged);
            // 
            // panel_Label
            // 
            this.panel_Label.Controls.Add(this.label1);
            this.panel_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Label.Location = new System.Drawing.Point(0, 0);
            this.panel_Label.Name = "panel_Label";
            this.panel_Label.Size = new System.Drawing.Size(598, 54);
            this.panel_Label.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discounts";
            // 
            // DiscountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel_Contents);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel_List);
            this.Controls.Add(this.panel_Label);
            this.Name = "DiscountsControl";
            this.Size = new System.Drawing.Size(598, 387);
            this.panel_Contents.ResumeLayout(false);
            this.panel_Contents.PerformLayout();
            this.group_Type.ResumeLayout(false);
            this.group_Type.PerformLayout();
            this.panel_Button.ResumeLayout(false);
            this.panel_List.ResumeLayout(false);
            this.panel_Label.ResumeLayout(false);
            this.panel_Label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Contents;
        private System.Windows.Forms.TextBox txtLess;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox group_Type;
        private System.Windows.Forms.RadioButton radio_Fixed;
        private System.Windows.Forms.RadioButton radio_Percent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Button;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel_List;
        private System.Windows.Forms.ListView lv_Discounts;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;

    }
}
