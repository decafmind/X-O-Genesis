using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetvetPOS_Inventory_System.Domain;

namespace PetvetPOS_Inventory_System
{
    public partial class Personalization : MyUserControl, IContentPage, IKeyController
    {
        ColorDialog colorDialog = new ColorDialog();
        Theme theme = new Theme();

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
                theme.HeaderColor = colorDialog.Color;
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
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                theme.IconColor = colorDialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                theme.SideBarColor = colorDialog.Color;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                theme = new Theme("Default", 
                    SystemColors.getColorFromArgb(44, 93, 99), 
                    SystemColors.getColorFromArgb(40, 55, 57), 
                    SystemColors.getColorFromArgb(169, 197, 47)
                    );
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                theme = new Theme("Desert Punk",
                    SystemColors.getColorFromArgb(227, 231, 179),
                    SystemColors.getColorFromArgb(246, 255, 226),
                    SystemColors.getColorFromArgb(215, 121, 72)
                    );
            }
        }

        private void Personalization_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            theme.Save(masterController);
            string message = string.Empty;
            if (theme.HeaderColor != null && theme.IconColor != null && theme.SideBarColor != null)
            {
                message = "Theme has been changed.";
            }
            else{
                if (theme.HeaderColor != null)
                    message = "Header color has been changed.";
                else if (theme.SideBarColor != null)
                    message = "Sidebar color has been changed.";
                else
                    message = "Icon color has been changed.";
            }
            MessageBanner banner = new MessageBanner(message);
            banner.Show();
        }
    }
}
