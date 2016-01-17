namespace PetvetPOS_Inventory_System
{
    partial class LoginPane
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPane = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lockPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.mainPane.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.mainPane);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 428);
            this.panel2.TabIndex = 1;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // mainPane
            // 
            this.mainPane.Controls.Add(this.progressBar1);
            this.mainPane.Controls.Add(this.panel5);
            this.mainPane.Location = new System.Drawing.Point(3, 3);
            this.mainPane.Name = "mainPane";
            this.mainPane.Size = new System.Drawing.Size(680, 334);
            this.mainPane.TabIndex = 10;
            this.mainPane.Resize += new System.EventHandler(this.mainPane_Resize);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(2, 224);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 10);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lockPanel);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(608, 220);
            this.panel5.TabIndex = 7;
            // 
            // lockPanel
            // 
            this.lockPanel.BackgroundImage = global::PetvetPOS_Inventory_System.Properties.Resources.lockIcon;
            this.lockPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lockPanel.Location = new System.Drawing.Point(293, 3);
            this.lockPanel.Name = "lockPanel";
            this.lockPanel.Size = new System.Drawing.Size(68, 59);
            this.lockPanel.TabIndex = 10;
            this.lockPanel.Visible = false;
            this.lockPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lockPanel_Paint);
            // 
            // LoginPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Name = "LoginPane";
            this.Size = new System.Drawing.Size(772, 428);
            this.panel2.ResumeLayout(false);
            this.mainPane.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel mainPane;
        private System.Windows.Forms.Panel lockPanel;
    }
}
