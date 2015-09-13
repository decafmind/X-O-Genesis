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
    public partial class MessageBanner : Form
    {
        private string message;
        // How many miliseconds until disapper
        private int interval;

        public MessageBanner()
        {
            InitializeComponent();
        }

        public MessageBanner(string message, int interval)
        {
            InitializeComponent();
            this.message = message;
            label1.Text = message;
            this.interval = interval;
            timer1.Interval = this.interval;
            timer1.Start();
        }

        public MessageBanner(string message)
        {
            InitializeComponent();
            this.message = message;
            label1.Text = message;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }


    }
}
