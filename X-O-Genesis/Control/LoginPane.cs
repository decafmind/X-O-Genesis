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
    // Controller

    public partial class LoginPane : MyUserControl, IContentPage
    {
        LoginControl loginControl1;
        public bool isLock;

        public LoginPane()
        {
            InitializeComponent();
        }

        public LoginPane(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            loginControl1 = new LoginControl(this, masterController, panel5);
        }


        public void startProgressbar()
        {
            progressBar1.Visible = true;
            progressBar1.Increment(50);
        }

        public void completeProgressBar()
        {
            progressBar1.Increment(50);
        }

        public void hideProgressbar()
        {
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        public void initializePage()
        {
            loginControl1.initLoginControl();
            hideProgressbar();
        }

        public Menu accessMenuName
        {
            get { return Menu.Login; }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.shopIcon; }
        }

        public void finalizePage()
        {
           // throw new NotImplementedException();
        }

        public void lockPane(){
            isLock = true;
            lockPanel.BackgroundImage = Properties.Resources.lockIcon;
            lockPanel.Visible = isLock;
        }

        public void unlockPane()
        {
            isLock = false;
            lockPanel.BackgroundImage = Properties.Resources.unlockIcon;
        }

        public void hideLockPane(){
            lockPanel.Visible = isLock;
        }

        private void lockPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPane_Resize(object sender, EventArgs e)
        {
            
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
           // mainPane.Location = new Point((Width - mainPane.Width )/ 2, (Height - mainPane.Height)/2);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
