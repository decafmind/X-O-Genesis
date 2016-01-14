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

        public Back(MasterController masterController):base(masterController)
        {
            InitializeComponent();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            masterController.returnToPreviousPage();
        }
    }
}
