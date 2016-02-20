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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountsControl));
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
            this.panel_Contents.SuspendLayout();
            this.group_Type.SuspendLayout();
            this.panel_Button.SuspendLayout();
            this.panel_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Contents
            // 
            this.panel_Contents.BackColor = System.Drawing.Color.White;
            this.panel_Contents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel_Contents.Location = new System.Drawing.Point(511, 83);
            this.panel_Contents.Name = "panel_Contents";
            this.panel_Contents.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Contents.Size = new System.Drawing.Size(465, 299);
            this.panel_Contents.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(295, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(19, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Discounts:";
            // 
            // txtLess
            // 
            this.txtLess.BackColor = System.Drawing.Color.White;
            this.txtLess.Enabled = false;
            this.txtLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLess.Location = new System.Drawing.Point(134, 220);
            this.txtLess.Name = "txtLess";
            this.txtLess.Size = new System.Drawing.Size(75, 23);
            this.txtLess.TabIndex = 7;
            this.txtLess.TextChanged += new System.EventHandler(this.txtLess_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDesc.Location = new System.Drawing.Point(132, 140);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(304, 66);
            this.txtDesc.TabIndex = 6;
            // 
            // group_Type
            // 
            this.group_Type.BackColor = System.Drawing.Color.White;
            this.group_Type.Controls.Add(this.radio_Fixed);
            this.group_Type.Controls.Add(this.radio_Percent);
            this.group_Type.Enabled = false;
            this.group_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.group_Type.Location = new System.Drawing.Point(132, 81);
            this.group_Type.Name = "group_Type";
            this.group_Type.Size = new System.Drawing.Size(304, 45);
            this.group_Type.TabIndex = 5;
            this.group_Type.TabStop = false;
            this.group_Type.Enter += new System.EventHandler(this.group_Type_Enter);
            // 
            // radio_Fixed
            // 
            this.radio_Fixed.AutoSize = true;
            this.radio_Fixed.BackColor = System.Drawing.Color.White;
            this.radio_Fixed.Location = new System.Drawing.Point(121, 17);
            this.radio_Fixed.Name = "radio_Fixed";
            this.radio_Fixed.Size = new System.Drawing.Size(111, 21);
            this.radio_Fixed.TabIndex = 1;
            this.radio_Fixed.TabStop = true;
            this.radio_Fixed.Text = "Fixed Amount";
            this.radio_Fixed.UseVisualStyleBackColor = false;
            // 
            // radio_Percent
            // 
            this.radio_Percent.AutoSize = true;
            this.radio_Percent.BackColor = System.Drawing.Color.White;
            this.radio_Percent.Location = new System.Drawing.Point(24, 17);
            this.radio_Percent.Name = "radio_Percent";
            this.radio_Percent.Size = new System.Drawing.Size(38, 21);
            this.radio_Percent.TabIndex = 0;
            this.radio_Percent.TabStop = true;
            this.radio_Percent.Text = "%";
            this.radio_Percent.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTitle.Location = new System.Drawing.Point(132, 52);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(304, 23);
            this.txtTitle.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount Less:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Discount Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Discount Type:";
            // 
            // panel_Button
            // 
            this.panel_Button.BackColor = System.Drawing.Color.White;
            this.panel_Button.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Button.Controls.Add(this.btnDelete);
            this.panel_Button.Controls.Add(this.btnEdit);
            this.panel_Button.Controls.Add(this.btnAdd);
            this.panel_Button.Location = new System.Drawing.Point(511, 378);
            this.panel_Button.Name = "panel_Button";
            this.panel_Button.Size = new System.Drawing.Size(465, 86);
            this.panel_Button.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(295, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 58);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEdit.Image = global::PetvetPOS_Inventory_System.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(168, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 58);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(23, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel_List
            // 
            this.panel_List.BackColor = System.Drawing.Color.White;
            this.panel_List.Controls.Add(this.lv_Discounts);
            this.panel_List.Location = new System.Drawing.Point(280, 83);
            this.panel_List.Name = "panel_List";
            this.panel_List.Padding = new System.Windows.Forms.Padding(5);
            this.panel_List.Size = new System.Drawing.Size(231, 376);
            this.panel_List.TabIndex = 6;
            // 
            // lv_Discounts
            // 
            this.lv_Discounts.BackColor = System.Drawing.Color.White;
            this.lv_Discounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lv_Discounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_Discounts.Location = new System.Drawing.Point(4, 5);
            this.lv_Discounts.Name = "lv_Discounts";
            this.lv_Discounts.Size = new System.Drawing.Size(221, 366);
            this.lv_Discounts.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lv_Discounts.TabIndex = 0;
            this.lv_Discounts.UseCompatibleStateImageBehavior = false;
            this.lv_Discounts.SelectedIndexChanged += new System.EventHandler(this.lv_Discounts_SelectedIndexChanged);
            // 
            // DiscountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel_Contents);
            this.Controls.Add(this.panel_Button);
            this.Controls.Add(this.panel_List);
            this.Name = "DiscountsControl";
            this.Size = new System.Drawing.Size(940, 532);
            this.panel_Contents.ResumeLayout(false);
            this.panel_Contents.PerformLayout();
            this.group_Type.ResumeLayout(false);
            this.group_Type.PerformLayout();
            this.panel_Button.ResumeLayout(false);
            this.panel_Button.PerformLayout();
            this.panel_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
