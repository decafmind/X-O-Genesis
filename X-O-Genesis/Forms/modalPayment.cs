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
    public partial class modalPayment : Form
    {
        public Decimal Payment { get; set; }
        public String CustomerName { get; set; }
        public String CustomerAddress { get; set; }

        public modalPayment()
        {
            InitializeComponent();
        }

        private void modalPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Payment = Decimal.Parse(txtCash.Text);
            CustomerAddress = txtCustomerAddress.Text;
            CustomerName = txtCustomerName.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
