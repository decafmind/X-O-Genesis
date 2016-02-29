namespace PetvetPOS_Inventory_System
{
    partial class BackUpControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbRestore = new System.Windows.Forms.GroupBox();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbBackup = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbRestore.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.gbRestore);
            this.panel4.Location = new System.Drawing.Point(638, 103);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(622, 377);
            this.panel4.TabIndex = 2;
            // 
            // gbRestore
            // 
            this.gbRestore.BackColor = System.Drawing.Color.White;
            this.gbRestore.Controls.Add(this.txtSelected);
            this.gbRestore.Controls.Add(this.btnRestore);
            this.gbRestore.Controls.Add(this.btnSelect);
            this.gbRestore.Controls.Add(this.label7);
            this.gbRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.gbRestore.Location = new System.Drawing.Point(10, 10);
            this.gbRestore.Name = "gbRestore";
            this.gbRestore.Size = new System.Drawing.Size(598, 353);
            this.gbRestore.TabIndex = 1;
            this.gbRestore.TabStop = false;
            this.gbRestore.Text = "Restore";
            // 
            // txtSelected
            // 
            this.txtSelected.Enabled = false;
            this.txtSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelected.Location = new System.Drawing.Point(29, 81);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(447, 20);
            this.txtSelected.TabIndex = 13;
            // 
            // btnRestore
            // 
            this.btnRestore.AutoSize = true;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.Location = new System.Drawing.Point(137, 131);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(254, 114);
            this.btnRestore.TabIndex = 12;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(500, 78);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 23);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "BROWSE";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(25, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Select File:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.gbBackup);
            this.panel3.Location = new System.Drawing.Point(17, 103);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(625, 377);
            this.panel3.TabIndex = 1;
            // 
            // gbBackup
            // 
            this.gbBackup.BackColor = System.Drawing.Color.White;
            this.gbBackup.Controls.Add(this.txtPath);
            this.gbBackup.Controls.Add(this.btnBackup);
            this.gbBackup.Controls.Add(this.btnPath);
            this.gbBackup.Controls.Add(this.label3);
            this.gbBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.gbBackup.Location = new System.Drawing.Point(10, 10);
            this.gbBackup.Name = "gbBackup";
            this.gbBackup.Size = new System.Drawing.Size(601, 353);
            this.gbBackup.TabIndex = 0;
            this.gbBackup.TabStop = false;
            this.gbBackup.Text = "Backup";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(32, 81);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(462, 20);
            this.txtPath.TabIndex = 8;
            // 
            // btnBackup
            // 
            this.btnBackup.AutoSize = true;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.Location = new System.Drawing.Point(173, 131);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(254, 114);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPath.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.ForeColor = System.Drawing.Color.White;
            this.btnPath.Location = new System.Drawing.Point(500, 78);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "BROWSE";
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Path to Save:";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 151);
            this.panel2.TabIndex = 0;
            // 
            // BackUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Name = "BackUpControl";
            this.Size = new System.Drawing.Size(1320, 583);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gbRestore.ResumeLayout(false);
            this.gbRestore.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gbBackup.ResumeLayout(false);
            this.gbBackup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbBackup;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label3;
    }
}
