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
        string[] anagram = new string[]{
                "Inventory System",
                "Never Give up",
                "Point of Sale",
                "We are Akira",
                "I am Karen",
                "I am Judy",
                "I am CJ",
                "I am Richmond",
                "I am Tricia",
                "I am Marjorie",
                "I am Rainier",
                "I am Raineir",
                "I am Randy",
                "I am Jesie",
                "I am Jerwin",
                "I am Jessea",
                "I am Mico",
                "I am Carla",
                "I am Francis",
                "I am Richard",
                "I am Jeroh",
                "I am Paolo  ",
                "I am Daniel",
                "I am Angelica",
                "Iam Sir Llaneta",
                "We are family",
            };
        Random random;

        public SplashScreen()
        {
            InitializeComponent();
            main = new frmMain();
            main.FormClosing += main_FormClosing;
            main.FormClosed += main_FormClosed;
            random = new Random();
        }

        void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel)
                return;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTitle.Text = "We are family";
            main.Show();
            this.Hide();
            timer1.Stop();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTitle.Text = anagram[random.Next(anagram.Length)];
        }
    }
}
