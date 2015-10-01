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
    public partial class KeyButton : MyUserControl
    {
     
        public KeyButton()
        {
            InitializeComponent();
        }

        public virtual void onClick()
        {
            //
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            updateButton();
            onClick();
        }

        public void updateButton()
        {
            rectangleShape1.FillColor = Color.White;
            rectangleShape1.BorderColor = Color.Black;
            lblKeyChar.BackColor = Color.White;
            lblKeyChar.ForeColor = Color.Black;

            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            updateButton();
            onClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape1.FillColor = Color.Black;
            rectangleShape1.BorderColor = Color.White;
            lblKeyChar.BackColor = Color.Black;
            lblKeyChar.ForeColor = Color.White;
            timer1.Stop();
        }

        public string accessKeyChar 
        {
            get
            {
                return lblKeyChar.Text;
            }
            set
            {
                lblKeyChar.Text = value;
            }
        }
    }
}
