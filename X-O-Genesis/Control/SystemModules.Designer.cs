namespace PetvetPOS_Inventory_System
{
    partial class SystemModules
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.advanceBorder = new System.Windows.Forms.Panel();
            this.pbAdvance = new System.Windows.Forms.PictureBox();
            this.simpleBorder = new System.Windows.Forms.Panel();
            this.pbSimple = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.advanceBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvance)).BeginInit();
            this.simpleBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimple)).BeginInit();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(266, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Apply System Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(494, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Advance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(172, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Simple";
            // 
            // advanceBorder
            // 
            this.advanceBorder.Controls.Add(this.pbAdvance);
            this.advanceBorder.Location = new System.Drawing.Point(404, 48);
            this.advanceBorder.Name = "advanceBorder";
            this.advanceBorder.Padding = new System.Windows.Forms.Padding(10);
            this.advanceBorder.Size = new System.Drawing.Size(250, 200);
            this.advanceBorder.TabIndex = 5;
            // 
            // pbAdvance
            // 
            this.pbAdvance.BackColor = System.Drawing.Color.Silver;
            this.pbAdvance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdvance.Location = new System.Drawing.Point(10, 10);
            this.pbAdvance.Name = "pbAdvance";
            this.pbAdvance.Size = new System.Drawing.Size(230, 180);
            this.pbAdvance.TabIndex = 0;
            this.pbAdvance.TabStop = false;
            this.pbAdvance.Click += new System.EventHandler(this.pbAdvance_Click);
            // 
            // simpleBorder
            // 
            this.simpleBorder.Controls.Add(this.pbSimple);
            this.simpleBorder.Location = new System.Drawing.Point(75, 48);
            this.simpleBorder.Name = "simpleBorder";
            this.simpleBorder.Padding = new System.Windows.Forms.Padding(10);
            this.simpleBorder.Size = new System.Drawing.Size(250, 200);
            this.simpleBorder.TabIndex = 4;
            // 
            // pbSimple
            // 
            this.pbSimple.BackColor = System.Drawing.Color.Silver;
            this.pbSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSimple.Location = new System.Drawing.Point(10, 10);
            this.pbSimple.Name = "pbSimple";
            this.pbSimple.Size = new System.Drawing.Size(230, 180);
            this.pbSimple.TabIndex = 2;
            this.pbSimple.TabStop = false;
            this.pbSimple.Click += new System.EventHandler(this.pbSimple_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label1.Location = new System.Drawing.Point(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT APPLICATION MODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 49);
            this.panel1.TabIndex = 1;
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Controls.Add(this.label3);
            this.centerPanel.Controls.Add(this.btnUpdate);
            this.centerPanel.Controls.Add(this.label2);
            this.centerPanel.Controls.Add(this.advanceBorder);
            this.centerPanel.Controls.Add(this.simpleBorder);
            this.centerPanel.Location = new System.Drawing.Point(79, 116);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(713, 416);
            this.centerPanel.TabIndex = 8;
            this.centerPanel.SizeChanged += new System.EventHandler(this.centerPanel_Resize);
            this.centerPanel.Resize += new System.EventHandler(this.centerPanel_Resize);
            // 
            // SystemModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.centerPanel);
            this.Name = "SystemModules";
            this.Size = new System.Drawing.Size(877, 583);
            this.Load += new System.EventHandler(this.SystemModules_Load);
            this.SizeChanged += new System.EventHandler(this.SystemModules_SizeChanged);
            this.advanceBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdvance)).EndInit();
            this.simpleBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSimple)).EndInit();
            this.centerPanel.ResumeLayout(false);
            this.centerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSimple;
        private System.Windows.Forms.Panel simpleBorder;
        private System.Windows.Forms.Panel advanceBorder;
        private System.Windows.Forms.PictureBox pbAdvance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel centerPanel;
    }
}
