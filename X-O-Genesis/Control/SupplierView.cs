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
    public partial class SupplierView : MyUserControl
    {
        public SupplierView(MasterController masterController, Panel panel):base(masterController, panel, true)
        {
            InitializeComponent();
        }

        public void viewSupplier(Supplier supplier)
        {
            lblSupplierName.Text = supplier.Name;
            lblSupplierAddress.Text = supplier.Address;
            lblContactNumber.Text = supplier.ContactNo;
            lblContactPerson.Text = supplier.ContactPerson;
        }
    }
}
