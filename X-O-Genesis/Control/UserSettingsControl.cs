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
    public partial class UserSettingsControl : MyUserControl
    {
        private string username;
        
        public UserSettingsControl()
        {
            InitializeComponent();
        }

        public UserSettingsControl(Panel panel, MasterController masterController):base(masterController, panel, false)
        {
            InitializeComponent();
            this.masterController.setUserSettingsControl = this;
            masterController.EmployeeLogin += masterController_EmployeeLogin;
            TabStop = false;
        }

        void masterController_EmployeeLogin(object sender, EmployeeArgs e)
        {
            appearWithUser(e.employee);
        }


        public string accessLoginName 
        {
            get{
                return username;
            }
            set{
                username = value;
                loginName.Text = "Welcome " + username;
            }
        }

        public Image accessLoginImage { set { panelImage.BackgroundImage = value; } }

        public void appearWithUser(Employee employee){
            if (employee.Position == UserLevel.ADMIN)
                loginName.ForeColor = Color.Gold;
            else
                loginName.ForeColor = Color.White;

            accessLoginName = employee.User_id;

            if (System.IO.File.Exists(@employee.ImagePath))
                accessLoginImage = Randy.GraphicsLibrary.Renderer.resizeImage(Image.FromFile(@employee.ImagePath) as Bitmap, panelImage.Width, panelImage.Height) as Image;
            else
                accessLoginImage = null;
            appear(DockStyle.Fill);
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            masterController.logout();
        }

        /// <summary>
        /// This method shouldn't be called by anyone except the masterController.logout() method
        /// </summary>
        public void returnHome()
        {
            masterController.OnEmployeeLogout(new EventArgs());
            disappear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            masterController.logout();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            masterController.logout();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.LightGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
        } 

    }
}
