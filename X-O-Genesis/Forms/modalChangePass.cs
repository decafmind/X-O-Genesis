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
    public partial class modalChangePass : Form
    {
        DatabaseController dbController;
        public string User;

        public modalChangePass(DatabaseController dbController)
        {
            InitializeComponent();
            this.dbController = dbController;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dbController.getSQAnswer(lblUser.Text, txtAns.Text))
            {
                MessageBox.Show("You can now change your password.");
                enableFields(false, true);
            }              
            else
                MessageBox.Show("Invalid answer.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modalChangePass_Load(object sender, EventArgs e)
        {
            fillChangePassModal(User);
            enableFields(true, false);
        }

        private void fillChangePassModal(string username)
        {
          
            lblUser.Text = username;
            int secretQIndex = dbController.getSqueryFromID(username) - 1;

            List<string> secretQ = new List<string>();
            secretQ = dbController.fallbackMapper.getListOfSquery();

            txtQuestion.Text = secretQ[secretQIndex].ToString();

        }

        private void enableFields(bool flag_panelA, bool flag_panelB)
        {
            txtAns.Enabled = flag_panelA;
            btnSubmit.Enabled = flag_panelA;
            btnCancel.Enabled = flag_panelA;

            txtPass1.Enabled = flag_panelB;
            txtPass2.Enabled = flag_panelB;
            btnChangePass.Enabled = flag_panelB;
            btnChangeCancel.Enabled = flag_panelB;         
        }

        private void btnChangeCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPass1.Text) && !string.IsNullOrWhiteSpace(txtPass2.Text)
                && txtPass1.Text.Equals(txtPass2.Text))
            {
                try
                {
                    if(dbController.changePass(lblUser.Text, txtPass2.Text))
                    {
                        MessageBox.Show("Successfull changing password. You can now login.");
                        this.Dispose();
                    }
                }
                catch(Exception ex)
                {
                    ErrorLog.Log(ex);
                    txtPass1.Text = string.Empty;
                    txtPass2.Text = string.Empty;
                }
    
            }
            else
            {
                MessageBox.Show("Invalid request. Please make sure you fill up all the required fields. Also, your passwords should match in order to continue.");
                txtPass1.Text = string.Empty;
                txtPass2.Text = string.Empty;
            }
        }

        private void txtAns_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(btnSubmit, e);
                txtPass1.Focus();
            }
        }

        private void txtPass2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangePass_Click(btnChangePass, e);
                txtPass1.Focus();
            }
        }

        private void lblBarcode_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
