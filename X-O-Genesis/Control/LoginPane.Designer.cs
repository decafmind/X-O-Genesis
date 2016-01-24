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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPane));
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPane = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lockPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.mainPane.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
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
            this.mainPane.BackColor = System.Drawing.Color.White;
            this.mainPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPane.Controls.Add(this.progressBar1);
            this.mainPane.Controls.Add(this.panel5);
            this.mainPane.Controls.Add(this.pictureBox1);
            this.mainPane.Location = new System.Drawing.Point(0, 3);
            this.mainPane.Name = "mainPane";
            this.mainPane.Size = new System.Drawing.Size(781, 584);
            this.mainPane.TabIndex = 10;
            this.mainPane.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPane_Paint);
            this.mainPane.Resize += new System.EventHandler(this.mainPane_Resize);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(209, 253);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(362, 18);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.lockPanel);
            this.panel5.Location = new System.Drawing.Point(169, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 248);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Name = "LoginPane";
            this.Size = new System.Drawing.Size(772, 428);
            this.panel2.ResumeLayout(false);
            this.mainPane.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel mainPane;
        private System.Windows.Forms.Panel lockPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
