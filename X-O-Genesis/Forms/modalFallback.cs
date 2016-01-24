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
    public partial class modalFallback : Form
    {
        DatabaseController dbController;
        bool userExists = false;

        public modalFallback()
        {

        }
        public modalFallback(DatabaseController dbController)
        {
            InitializeComponent();
            this.dbController = dbController;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                userExists = dbController.userMapper.checkUsername(txtUser.Text);
                if (userExists)
                {
                    using(modalChangePass changePass = new modalChangePass(dbController))
                    {
                        changePass.User = txtUser.Text;
                        this.Hide();
                        System.Threading.Thread.Sleep(500);
                        changePass.ShowDialog();
                    }             
                }
                else
                {
                    MessageBox.Show("No such user exists.", "Forgot Password");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(btnSubmit, e);
            }
        }

    }
}
