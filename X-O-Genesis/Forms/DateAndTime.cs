using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System.Forms
{
    public partial class DateAndTime : UserControl
    {
        public DateAndTime()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void DateAndTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void setForeColor(Color color)
        {
            label1.ForeColor = color;
        }
    }
}
