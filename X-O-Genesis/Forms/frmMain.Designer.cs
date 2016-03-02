using System.Drawing;

namespace PetvetPOS_Inventory_System
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.subHeader = new System.Windows.Forms.Panel();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dateAndTime1 = new PetvetPOS_Inventory_System.DateAndTime();
            this.back1 = new PetvetPOS_Inventory_System.Back();
            this.subHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(1, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(998, 78);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(1, 80);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(91, 655);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // subHeader
            // 
            this.subHeader.BackColor = System.Drawing.Color.White;
            this.subHeader.Controls.Add(this.userControlPanel);
            this.subHeader.Controls.Add(this.panel3);
            this.subHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.subHeader.Location = new System.Drawing.Point(92, 80);
            this.subHeader.Name = "subHeader";
            this.subHeader.Size = new System.Drawing.Size(907, 36);
            this.subHeader.TabIndex = 0;
            // 
            // userControlPanel
            // 
            this.userControlPanel.BackColor = System.Drawing.Color.White;
            this.userControlPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userControlPanel.Location = new System.Drawing.Point(584, 0);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(323, 36);
            this.userControlPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dateAndTime1);
            this.panel3.Controls.Add(this.back1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(361, 36);
            this.panel3.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(92, 116);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(907, 619);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dateAndTime1
            // 
            this.dateAndTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateAndTime1.Location = new System.Drawing.Point(52, 0);
            this.dateAndTime1.Name = "dateAndTime1";
            this.dateAndTime1.Padding = new System.Windows.Forms.Padding(10);
            this.dateAndTime1.Size = new System.Drawing.Size(299, 36);
            this.dateAndTime1.TabIndex = 0;
            // 
            // back1
            // 
            this.back1.accessMasterController = null;
            this.back1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.back1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back1.dbController = null;
            this.back1.Dock = System.Windows.Forms.DockStyle.Left;
            this.back1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.back1.Location = new System.Drawing.Point(10, 0);
            this.back1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.back1.masterController = null;
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(42, 36);
            this.back1.TabIndex = 1;
            this.back1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 736);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.subHeader);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.subHeader.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel subHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel userControlPanel;
        private DateAndTime dateAndTime1;
        private System.Windows.Forms.Panel mainPanel;
        private Back back1;
    }
}

