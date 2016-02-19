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
    public partial class SystemSettings : MyUserControl, IContentPage, IKeyController
    {

        public SystemSettings()
        {
            InitializeComponent();
        }

        public SystemSettings(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
        }
        private void UserSettings_Load(object sender, EventArgs e)
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
                return Menu.Settings;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Ayos na'to ehh
        }

        private void picCompProf_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new CompanyProfile(base.masterController));
        }

        private void pbPersonalization_Click(object sender, EventArgs e)
        {
            Personalization personalization = new Personalization(base.masterController);
            masterController.changeCurrentContent(personalization);
        }

        private void pbProductReturn_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new ProductReturnControl(base.masterController));
        }

        private void pbModules_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new SystemModules(base.masterController));
        }

        private void picTax_Click(object sender, EventArgs e)
        {
            masterController.changeCurrentContent(new DiscountsControl(base.masterController));
        }
    }
}
