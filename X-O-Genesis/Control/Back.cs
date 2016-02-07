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
    public partial class Back : MyUserControl
    {
        public Back()
        {
            InitializeComponent();
        }

        public override MasterController masterController
        {
            get
            {
                return base.masterController;
            }
            set
            {
                base.masterController = value;
              //  base.masterController.ContentChanged += masterController_ContentChanged;
            }
        }

        void masterController_ContentChanged(object sender, ContentArgs e)
        {
            if (masterController.history.Count == 0)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = true;
            }
        }

        public Back(MasterController masterController):base(masterController)
        {
            InitializeComponent();
        }

        private void Back_Load(object sender, EventArgs e)
        {

        }
        public void enable(bool flag)
        {
            if (flag)
            {
                lineShape1.BorderColor = Color.Black;
                lineShape2.BorderColor = Color.Black;
                lineShape3.BorderColor = Color.Black;
            }
            else
            {
                lineShape1.BorderColor = Color.Gray;
                lineShape2.BorderColor = Color.Gray;
                lineShape3.BorderColor = Color.Gray;
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            masterController.returnToPreviousPage();
        }
    }
}
