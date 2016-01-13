namespace PetvetPOS_Inventory_System
{
    partial class MenuControl
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
            this.menuName = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalEarHoleR = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalEarHoleL = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalEarR = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalEarL = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.icon = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuName
            // 
            this.menuName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuName.ForeColor = System.Drawing.Color.White;
            this.menuName.Location = new System.Drawing.Point(0, 89);
            this.menuName.MaximumSize = new System.Drawing.Size(105, 39);
            this.menuName.Name = "menuName";
            this.menuName.Size = new System.Drawing.Size(105, 39);
            this.menuName.TabIndex = 1;
            this.menuName.Text = "Menu Name";
            this.menuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuName.Click += new System.EventHandler(this.menuName_Click);
            this.menuName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblDesc_MouseClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalEarHoleR,
            this.ovalEarHoleL,
            this.ovalEarR,
            this.ovalEarL,
            this.icon});
            this.shapeContainer1.Size = new System.Drawing.Size(105, 128);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalEarHoleR
            // 
            this.ovalEarHoleR.BackColor = System.Drawing.Color.White;
            this.ovalEarHoleR.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalEarHoleR.BorderColor = System.Drawing.Color.White;
            this.ovalEarHoleR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalEarHoleR.Location = new System.Drawing.Point(73, 20);
            this.ovalEarHoleR.Name = "ovalEarHoleR";
            this.ovalEarHoleR.Size = new System.Drawing.Size(13, 8);
            this.ovalEarHoleR.Click += new System.EventHandler(this.ovalShape4_Click);
            // 
            // ovalEarHoleL
            // 
            this.ovalEarHoleL.BackColor = System.Drawing.Color.White;
            this.ovalEarHoleL.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalEarHoleL.BorderColor = System.Drawing.Color.White;
            this.ovalEarHoleL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalEarHoleL.Location = new System.Drawing.Point(18, 20);
            this.ovalEarHoleL.Name = "ovalEarHoleL";
            this.ovalEarHoleL.Size = new System.Drawing.Size(13, 8);
            this.ovalEarHoleL.Click += new System.EventHandler(this.ovalShape4_Click);
            // 
            // ovalEarR
            // 
            this.ovalEarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(157)))));
            this.ovalEarR.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalEarR.BorderColor = System.Drawing.Color.White;
            this.ovalEarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalEarR.Location = new System.Drawing.Point(69, 10);
            this.ovalEarR.Name = "ovalEarR";
            this.ovalEarR.Size = new System.Drawing.Size(20, 19);
            this.ovalEarR.Click += new System.EventHandler(this.ovalShape4_Click);
            // 
            // ovalEarL
            // 
            this.ovalEarL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(157)))));
            this.ovalEarL.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalEarL.BorderColor = System.Drawing.Color.White;
            this.ovalEarL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ovalEarL.Location = new System.Drawing.Point(12, 11);
            this.ovalEarL.Name = "ovalEarL";
            this.ovalEarL.Size = new System.Drawing.Size(20, 19);
            this.ovalEarL.Click += new System.EventHandler(this.ovalShape4_Click);
            // 
            // icon
            // 
            this.icon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(148)))), ((int)(((byte)(157)))));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.icon.BorderColor = System.Drawing.Color.White;
            this.icon.BorderWidth = 2;
            this.icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon.Location = new System.Drawing.Point(14, 20);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(75, 65);
            this.icon.Click += new System.EventHandler(this.icon_Click);
            this.icon.MouseHover += new System.EventHandler(this.icon_MouseHover);
            this.icon.Paint += new System.Windows.Forms.PaintEventHandler(this.icon_Paint);
            // 
            // MenuControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.menuName);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(105, 128);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            this.Click += new System.EventHandler(this.MenuControl_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape icon;
        private System.Windows.Forms.Label menuName;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalEarL;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalEarHoleR;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalEarHoleL;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalEarR;
    }
}
