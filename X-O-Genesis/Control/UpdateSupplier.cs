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
    public partial class UpdateSupplier : MyUserControl
    {
        Supplier oldSupplier;

        public UpdateSupplier()
        {
            InitializeComponent();
        }

        public UpdateSupplier(MasterController masterController, Panel panel)
            : base(masterController, panel, true)
        {
            InitializeComponent();
        }

        public void mapSupplier(Supplier supplier)
        {
            oldSupplier = supplier;
            txtName.Text = supplier.Name;
            txtAddress.Text = supplier.Address;
            txtNumber.Text = supplier.ContactNo;
            txtPerson.Text = supplier.ContactPerson;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MyExtension.Validation.isFilled(this))
            {
                Supplier newSupplier = new Supplier()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    ContactNo = txtNumber.Text,
                    ContactPerson = txtPerson.Text,
                };

                if (dbController.supplierMapper.updateSupplier(oldSupplier, newSupplier))
                {
                    MessageBanner messageBanner = new MessageBanner(string.Format("Product {0} has been updated", newSupplier.Name));
                    messageBanner.Show();
                    oldSupplier = null;
                }
            }
        }
    }
}