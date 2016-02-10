using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class MyUserControl : UserControl
    {
        protected Panel container;
        public virtual MasterController masterController { get; set; }
        public virtual DatabaseController dbController { get; set; }

        public MyUserControl()
        {
            InitializeComponent();
        }

        public MyUserControl(MasterController masterController, Panel panel, bool isVisible)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
            this.container = panel;
            this.masterController = masterController;

            if (isVisible)
                appear(DockStyle.Fill);
           
        }

        public MyUserControl(MasterController masterController, Panel panel, DockStyle dockStyle)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
            this.container = panel;
            this.masterController = masterController;
            appear(dockStyle);
        }

        public MyUserControl(MasterController masterController)
        {
            this.masterController = masterController;
            this.dbController = masterController.DataBaseController;
        }

        public void appear(DockStyle dockStyle)
        {
            if (dockStyle == DockStyle.Fill)
            {
                foreach (Control control in container.Controls)
                {
                    MyUserControl myUserControl = control as MyUserControl;
                    if (myUserControl != null)
                        myUserControl.disappear();
                }

                container.Controls.Clear();
            }

            this.container.SuspendLayout();
            this.Dock = dockStyle;
            this.Location = new Point(0, 0);
            this.container.Controls.Add(this);
            this.container.ResumeLayout(true);
        }

        public void appear(DockStyle dockStyle, Panel panel){
            this.container = panel;
            appear(dockStyle);
        }

        public void disappear()
        {
            doBeforeDisappearance();
            container.Controls.Remove(this);
        }

        public MasterController accessMasterController 
        {
            get { return masterController; }
            set { this.masterController = value; }
        }

        protected virtual void doBeforeDisappearance()
        {

        }

        private void MyUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
