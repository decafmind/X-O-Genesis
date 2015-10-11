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
        DataTable existingClientTable;
        public CustomerInformationView()
        {
            InitializeComponent();
            orderSliderPane1.Visible = false;
        }

        public CustomerInformationView(MasterController masterController):base(masterController)
        {
            InitializeComponent();
            dbController = masterController.DataBaseController;
            orderSliderPane1.accessMasterController = masterController;
            existingClientTable = new DataTable();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           // customerInfo_panel.SetBounds((this.Width  - customerInfo_panel.Width)/2, (this.Height - customerInfo_panel.Height)/2, customerInfo_panel.Width, customerInfo_panel.Height);
        }

        public KeyFunction getKeyController
        {
            get { return customerInformationViewKeys; }
        }

        public Menu accessMenuName
        {
            get { return Menu.Client; }
        }

        void customerInformationViewKeys(KeyEventArgs e)
        {
            if (orderSliderPane1.isOpen())
            {
                KeyFunction keyFunction = orderSliderPane1.getKeyController;
                if (keyFunction != null)
                {
                    keyFunction(e);
                }
            }
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

        private CustomerInformation customerInformation;

        private void btnSave_Click(object sender, EventArgs e)
        {
            customerInformation = new CustomerInformation()
            {
                Firstname = txtFname.Text,
                Middlename = txtMname.Text,
                Lastname = txtLname.Text,
                Mobile_number = txtMobile.Text,
                Telephone_number = txtMobile.Text,
                Email_address = txtEmail.Text,
                Address = txtAdd1.Text + " " + txtAdd2.Text
            };

  
            if (Validation.isFilled(newClient_tab))
            {
                dbController.customerInformationMapper.insertCustomerInformation(customerInformation);
            }
            else
            {
                MessageBanner banner = new MessageBanner("Please fill up the required fields.", 2000);
                banner.ForeColor = System.Drawing.Color.Red;
                banner.Show();
            }

            MyExtension.Validation.clearFields(newClient_tab);
            
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            orderSliderPane1.Visible = true;
            orderSliderPane1.toggle();
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtClientName.Text))
                txtClientName.BackColor = SystemColors.loginDullYellow;
            else
            {
                existingClientTable.Dispose();
                dgExistingClients.DataSource = null;
                txtClientName.BackColor = Color.White;
            }
    

            search(txtClientName.Text);           
        }

        private void search(string token)
        {
            filtergdExistingClients(token);
        }

        private void filtergdExistingClients(string token)
        {
            if (!string.IsNullOrWhiteSpace(token))
            {
                existingClientTable = new DataTable();
                dbController.filterExistingClientsByLastname(existingClientTable, token);
                dgExistingClients.DataSource = existingClientTable;
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            MyExtension.Validation.clearFields(newClient_tab);
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            MessageBanner banner; 
            if (MyExtension.Validation.isFilled(updateContacts_panel))
            {
                customerInformation = new CustomerInformation()
                {
                    Mobile_number = mob
                };

                if (dbController.updateContacts(customerInformation.Mobile_number, txtUpdateMobile.Text, txtUpdateOtherContacts.Text))
                {          
                    banner = new MessageBanner("Successful updating contact details.", 2000);
                    banner.Show();
                }
                else
                {
                    banner = new MessageBanner("Failed updating contact details.", 2000);
                    banner.ForeColor = Color.Red;
                    banner.Show();
                }
            }

            MyExtension.Validation.clearFields(updateContacts_panel);
        }
        private void fillUpdateContacts(string token1, string token2)
        {
            if (!string.IsNullOrWhiteSpace(token1) && !string.IsNullOrWhiteSpace(token2))
            {
                existingClientTable = new DataTable();
                CustomerInformation customerInformation = dbController.getExistingClientContacts(existingClientTable, token1, token2);
                txtUpdateMobile.Text = customerInformation.Mobile_number;
                txtUpdateOtherContacts.Text = customerInformation.Telephone_number;
                
            }

        }
        private static string mob, lastname;
        void getValueFromDataGridCell()
        {
            const int LAST_NAME = 2;
            const int MOBILE_NUMBER = 3;

            if (dgExistingClients.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgExistingClients.SelectedRows[0];
                mob = getValueFromDataGridCell(dgExistingClients, row.Index, MOBILE_NUMBER).ToString();
                lastname = getValueFromDataGridCell(dgExistingClients, row.Index, LAST_NAME).ToString();
            }

        }
        object getValueFromDataGridCell(DataGridView gv, int row_index, int cell_index)
        {
            return gv.Rows[row_index].Cells[cell_index].Value;
        }

        private void dgExistingClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getValueFromDataGridCell();
            fillUpdateContacts(lastname, mob);
        }
       

    }
}
