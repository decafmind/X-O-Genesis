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
    public partial class Supplier : MyUserControl, IContentPage, IKeyController
    {
        public Supplier()
        {
            InitializeComponent();
        }

        public Bitmap accessImage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Menu accessMenuName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public KeyFunction getKeyController
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void finalizePage()
        {
            throw new NotImplementedException();
        }

        public void initializePage()
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
