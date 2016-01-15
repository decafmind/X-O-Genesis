using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class CriticalNotif : Form
    {
        public CriticalNotif()
        {
            InitializeComponent();
        }

        public CriticalNotif(Product product, int qty_left)
        {
            InitializeComponent();
            string message = string.Empty;
            if (qty_left == 0)
            {
                message = string.Format("Product {0} is OUT OF STOCK.", product.Description);
            }
            else
            {
                message = string.Format("Product {0} is already in critical level. {1} left.", product.Description, qty_left);
            }
             
            label1.Text = message;
        }

        private void CriticalNotif_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CriticalNotif_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
