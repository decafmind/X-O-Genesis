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
    public partial class Personalization : MyUserControl, IContentPage, IKeyController
    {
        DatabaseController dbController;
        ColorDialog colorDialog = new ColorDialog();
        SettingArgs s = new SettingArgs(Settings.PERSONALIZATION);

        public Personalization()
        {
            InitializeComponent();
        }

        public Personalization(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.headerColor = colorDialog.Color;
                Properties.Settings.Default.Save();
                masterController.OnSettingsChanged(s);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.sidebarColor = colorDialog.Color;
                Properties.Settings.Default.Save();
                masterController.OnSettingsChanged(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Properties.Settings.Default.headerColor = SystemColors.getColorFromArgb(44, 93, 99);
                Properties.Settings.Default.iconColor = SystemColors.getColorFromArgb(40, 55, 57);
                Properties.Settings.Default.sidebarColor = SystemColors.getColorFromArgb(169, 197, 47);
               
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Properties.Settings.Default.headerColor = SystemColors.getColorFromArgb(227, 231, 179);
                Properties.Settings.Default.iconColor = SystemColors.getColorFromArgb(246, 255, 226); 
                Properties.Settings.Default.sidebarColor = SystemColors.getColorFromArgb(215, 121, 72);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            masterController.OnSettingsChanged(s);
        }

        private void Personalization_Load(object sender, EventArgs e)
        {

        }
    }
}
