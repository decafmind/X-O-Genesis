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
    public partial class FBUser : MyUserControl
    {
        private User user;
        private Fallback fallback;
        DatabaseController dbController;

        public FBUser() 
        {
            InitializeComponent();
        }
        public FBUser(Fallback fallback, MasterController masterController, Panel panel) 
            : base(masterController, panel, true)
        {
            InitializeComponent();
            this.fallback = fallback;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
