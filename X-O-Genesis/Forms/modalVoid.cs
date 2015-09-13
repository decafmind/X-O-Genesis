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
    public partial class modalVoid : Form
    {

        private DialogResult selectedResult;
        private DatabaseController dbController;
        // Drop shadow
        private const int CS_DROPSHADOW = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public modalVoid()
        {
            InitializeComponent();
        }

        public modalVoid(DatabaseController dbController)
        {
            InitializeComponent();
            this.dbController = dbController;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = dbController.authenticateUser(username, password);

            if (user != null && user.getUserLevel() == UserLevel.ADMIN)
                selectedResult = DialogResult.OK;
            else
                selectedResult = DialogResult.Cancel;

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedResult = DialogResult.Cancel;
            Close();
        }

        public DialogResult getResult { get { return selectedResult; } }



    }
}
