using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class SplashScreen : Form
    {
        frmMain main = new frmMain();

        public SplashScreen()
        {
            InitializeComponent();
            main.FormClosed += main_FormClosed;
        }

        void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

     
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
            timer2.Stop();
        }

        private void SplashScreen_Load_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

    }
}
