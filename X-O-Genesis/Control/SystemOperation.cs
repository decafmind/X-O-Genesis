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
    public partial class SystemOperation : MyUserControl, IContentPage, IKeyController
    {
        public SystemOperation()
        {
            InitializeComponent();
        }

        public SystemOperation(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
        }

        private void SystemOperation_Load(object sender, EventArgs e)
        {

        }

        public void initializePage()
        {

        }

        public void finalizePage()
        {

        }

        public Menu accessMenuName
        {
            get
            {
                return Menu.System_Operation;
            }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.settingsIcon; }
        }

        public KeyFunction getKeyController
        {
            get
            {
                return null;
            }
        }


        private void pbSystemSettings_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new SystemSettings(base.masterController));
        }

        private void pbUserManagement_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new UserAdministration(base.masterController, 0));
        }

        private void pbLoginTrail_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new UserAdministration(base.masterController, 2));
        }

        private void pbAuditTrail_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new UserAdministration(base.masterController, 1));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


    }
}
