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
    public partial class SystemModules : MyUserControl, IContentPage, IKeyController
    {
        bool isInSimpleMode = true;

        public SystemModules()
        {
            InitializeComponent();
        }

        public SystemModules(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
        }

        private void SystemModules_Load(object sender, EventArgs e)
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
            get { return Menu.Modules; }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.settingsIcon; }
        }

        public KeyFunction getKeyController
        {
            get { return new KeyFunction(ModulesKeyFunction); }
        }

        public void ModulesKeyFunction(KeyEventArgs e){

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isInSimpleMode)
                dbController.systemSettingsMapper.updateSettings("mode", "simple");
            else
                dbController.systemSettingsMapper.updateSettings("mode", "advance");

            Properties.Settings.Default.SimpleMode = isInSimpleMode;
            Properties.Settings.Default.Save();
            MessageBox.Show("You need to restart the application to apply changes.",  "Applying changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void centerPanel_Resize(object sender, EventArgs e)
        {

        }

        private void SystemModules_SizeChanged(object sender, EventArgs e)
        {
            centerPanel.Location = new Point(((Width - centerPanel.Width) / 2), centerPanel.Location.Y);
        }

        private void pbSimple_Click(object sender, EventArgs e)
        {
            simpleBorder.BackColor = SystemColors.menuLightBlue;
            advanceBorder.BackColor = Color.White;
            isInSimpleMode = true;
        }

        private void pbAdvance_Click(object sender, EventArgs e)
        {
            simpleBorder.BackColor = Color.White;
            advanceBorder.BackColor = SystemColors.menuLightBlue;
            isInSimpleMode = false;
        }

    }
}
