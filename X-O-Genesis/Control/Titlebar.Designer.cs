namespace PetvetPOS_Inventory_System
{
    partial class Titlebar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titlebar));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(35, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 26);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.toolTip1.SetToolTip(this.button3, "Toggle fullscreen");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(76, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 26);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "X";
            this.toolTip1.SetToolTip(this.button2, "Close");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "_";
            this.toolTip1.SetToolTip(this.button1, "Minimize");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 92);
            this.panel1.TabIndex = 2;
            // 
            // panelTitle
            // 
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitle.Location = new System.Drawing.Point(90, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelTitle.Size = new System.Drawing.Size(476, 92);
            this.panelTitle.TabIndex = 6;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panelTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDoubleClick);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(566, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 92);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDoubleClick);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 26);
            this.panel5.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(90, 92);
            this.panelImage.TabIndex = 5;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            this.panelImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDoubleClick);
            this.panelImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // Titlebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panel1);
            this.Name = "Titlebar";
            this.Size = new System.Drawing.Size(681, 92);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
