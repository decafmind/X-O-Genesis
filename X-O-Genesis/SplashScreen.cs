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
        frmMain main;

        public SplashScreen()
        {
            InitializeComponent();
            main = new frmMain();
            main.FormClosing += main_FormClosing;
        }

        void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string[] anagram = new string[]{
                "Inventory System",
                "Never Give up",
                "Point of Sale",
                "We are family",
            };
            Random random = new Random();
            lblTitle.Text = anagram[random.Next(anagram.Length)];

        }


    }
}
