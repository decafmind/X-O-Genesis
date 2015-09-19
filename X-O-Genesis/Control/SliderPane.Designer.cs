namespace PetvetPOS_Inventory_System
{
    partial class SliderPane
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(25, 16);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(242, 334);
            this.contentPanel.TabIndex = 0;
            // 
            // SliderPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentPanel);
            this.MaximumSize = new System.Drawing.Size(300, 1000);
            this.MinimumSize = new System.Drawing.Size(30, 600);
            this.Name = "SliderPane";
            this.Size = new System.Drawing.Size(300, 600);
            this.Load += new System.EventHandler(this.SliderPane_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SliderPane_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        protected System.Windows.Forms.Panel contentPanel;
    }
}
