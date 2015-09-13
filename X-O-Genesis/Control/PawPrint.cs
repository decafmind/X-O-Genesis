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
    // For Design purpose only
    public partial class PawPrint : UserControl
    {
        public PawPrint()
        {
            InitializeComponent();
        }

        public Color PawColor 
        {
            get
            {
                return ovalShape12.BackColor;
            }

            set
            {
                Color thisColor = value;
                ovalShape9.BackColor = thisColor;
                ovalShape10.BackColor = thisColor;
                ovalShape11.BackColor = thisColor;
                ovalShape12.BackColor = thisColor;
            }
        }
    }
}
