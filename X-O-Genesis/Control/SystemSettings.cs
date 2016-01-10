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
        DatabaseController dbController;

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
            get { return Properties.Resources.userBlack; }
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Personalization personalization = new Personalization(base.masterController);
            masterController.changeCurrentContent(personalization);
        }
    }
}
