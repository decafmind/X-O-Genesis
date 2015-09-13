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
    public partial class CustomerInformation :  MyUserControl, IContentPage, IKeyController
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        public CustomerInformation(MasterController masterController):base(masterController)
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.SetBounds((this.Width  - panel1.Width)/2, (this.Height - panel1.Height)/2, panel1.Width, panel1.Height);
        }



        public KeyFunction getKeyController
        {
            get;
            set;
        }


        public Menu accessMenuName
        {
            get { return Menu.CustomerInformation; }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.usersIcon; }
        }

        public void initializePage()
        {
        
        }


        public void finalizePage()
        {
        
        }

    }
}
