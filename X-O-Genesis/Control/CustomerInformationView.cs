using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyExtension;

namespace PetvetPOS_Inventory_System
{
    public partial class CustomerInformationView :  MyUserControl, IContentPage, IKeyController
    {
        DatabaseController dbController;
        public CustomerInformationView()
        {
            InitializeComponent();
        }

        public CustomerInformationView(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            dbController = masterController.DataBaseController;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            customerInfo_panel.SetBounds((this.Width  - customerInfo_panel.Width)/2, (this.Height - customerInfo_panel.Height)/2, customerInfo_panel.Width, customerInfo_panel.Height);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerInformation customer = new CustomerInformation()
            {
               Firstname = txtFname.Text,
               Middlename = txtMname.Text,
               Lastname = txtLname.Text,
               Mobile_number = txtMobile.Text,
               Telephone_number = txtMobile.Text,
               Email_address = txtEmail.Text,
               Address = txtAdd1.Text + " " + txtAdd2.Text               
            };

            if (Validation.isFilled(customerInfo_panel))
            {
                dbController.customerInformationMapper.insertCustomerInformation(customer);
            }
            
        }

    }
}
