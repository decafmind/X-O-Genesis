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
    public partial class AddSupplier : MyUserControl
    {
        public event EventHandler SupplierAdded;
 
        public AddSupplier(MasterController masterController, Panel panel):base(masterController, panel, true)
        {
            InitializeComponent();
        }

        public void OnSupplierAdded(EventArgs e)
        {
            EventHandler onSupplierAdded = SupplierAdded;
            if (onSupplierAdded != null)
                onSupplierAdded(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MyExtension.Validation.isFilled(this))
            {
                Supplier supplier = new Supplier()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    ContactNo = txtNumber.Text,
                    ContactPerson = txtPerson.Text,
                };

                if (dbController.supplierMapper.createSupplier(supplier))
                {
                    OnSupplierAdded(new EventArgs());
                    MessageBanner banner = new MessageBanner(supplier.Name + " was added on the supplier list.");
                    banner.ShowDialog();
                }
            }
            else
            {
                MessageBanner banner = new MessageBanner("Please fill up all fields.");
                banner.BackColor = Color.Red;
                banner.ForeColor = Color.White;
                banner.ShowDialog();
            }
        }
    }
}
