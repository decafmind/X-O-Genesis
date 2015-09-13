namespace PetvetPOS_Inventory_System
{
    partial class Slash
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(90, 89);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Red;
            this.lineShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 76;
            this.lineShape3.X2 = 26;
            this.lineShape3.Y1 = 32;
            this.lineShape3.Y2 = 81;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Red;
            this.lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 74;
            this.lineShape2.X2 = 22;
            this.lineShape2.Y1 = 6;
            this.lineShape2.Y2 = 64;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Red;
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 49;
            this.lineShape1.X2 = 5;
            this.lineShape1.Y1 = 8;
            this.lineShape1.Y2 = 54;
            // 
            // Slash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.Name = "Slash";
            this.Size = new System.Drawing.Size(90, 89);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}
