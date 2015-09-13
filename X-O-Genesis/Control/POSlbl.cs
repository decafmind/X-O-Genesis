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
    public partial class POSlbl : UserControl
    {
        public POSlbl()
        {
            InitializeComponent();
        }

       
        public override string Text{
            get{
                return label2.Text;
            }
            set{
                label2.Text = value;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
