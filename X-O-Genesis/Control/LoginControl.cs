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
    public partial class LoginControl : MyUserControl
    {
        private User user;
        private LoginPane loginPane;
        private int loginAttempt = 0;
        DatabaseController dbController;

        private string Username;
        private string Password;

        public LoginControl() { InitializeComponent(); }
        
        public LoginControl(LoginPane loginPane, MasterController masterController, Panel panel)
            : base(masterController, panel, true)
        {
            InitializeComponent();
            this.loginPane = loginPane;
            base.masterController.EmployeeLogout += masterController_EmployeeLogout;
        }

        void masterController_EmployeeLogout(object sender, EventArgs e)
        {
            initLoginControl();
        }

        public string accessLoginMessage 
        {
            get { return lblWelcomeMsg.Text; }
            set { lblWelcomeMsg.Text = value; }
        }

        public Button getBtnLoginReference
        {
            get { return btnLogin; }
        }

        public string getUserInput_Username
        {
            get { return txtUsername.Text; }
        }

        public string getUserInput_Password
        {
            get { return txtPassword.Text; }
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            initLoginControl();
        }

        public void initLoginControl()
        {
            dbController = masterController.DataBaseController;
            txtUsername.Focus();
            masterController.setFormReturnkey = btnLogin;
            accessLoginMessage = "Welcome! You may now login";

            loginAttempt = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e){
            
            if (dbController == null)
                dbController = masterController.DataBaseController;

            btnLogin.Enabled = false;
            Username = getUserInput_Username;
            Password = getUserInput_Password;

            loginPane.startProgressbar();

            try
            {
                backgroundWorker1.RunWorkerAsync();
            }
            catch (InvalidOperationException ioe)
            {
                ErrorLog.Log(ioe);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e){
            loginSequence();
        }

        private void loginSequence(){
            timer1.Stop();
            
            if (user != null && !dbController.isAlreadyLogin(user)){
                if (loginPane.isLock){
                    if (user.getUserLevel() == UserLevel.ADMIN)
                        authorizeLogin();
                    else
                        denyLogin();
                }else{
                    authorizeLogin();
                }
            }
            else{
                denyLogin();
            }

            btnLogin.Enabled = true;
        }

        private void denyLogin()
        {
            loginAttempt++;
            accessLoginMessage = "Welcome. You may try again";

            if (loginPane.isLock){
                MessageBox.Show("Something's not right..", "Contact your admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (loginAttempt == 3){
                MessageBox.Show("Login as admin to unlock the system", "System was locked", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                loginPane.lockPane();
            }
            else{
                MessageBox.Show("Login Failed. " + (3 - loginAttempt) + " attemp/s left", "Wrong Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtPassword.Clear();
            txtUsername.Focus();
            txtUsername.SelectAll();
            loginPane.hideProgressbar();
        }

        private void authorizeLogin()
        {
            if (!loginPane.isLock)
                loginPane.hideLockPane();

            txtUsername.Clear();
            txtPassword.Clear();

            EmployeeArgs employeeArgs = new EmployeeArgs(dbController.getEmployeeFromUser(user));
            masterController.OnEmployeeLogin(employeeArgs);
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string acceptedChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            MyExtension.Validation.limitTextbox(t, acceptedChar);

            if (!String.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)){
                txtUsername.BackColor = SystemColors.loginDullYellow;
                txtPassword.BackColor = txtUsername.BackColor;
            }
            else{
                txtUsername.BackColor = Color.White;
                txtPassword.BackColor = txtUsername.BackColor;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            user = dbController.authenticateUser(Username, Password);
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (user != null){
                if (loginPane.isLock && user.getUserLevel() == UserLevel.ADMIN)
                    loginPane.unlockPane();
            }

            timer1.Start();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loginPane.completeProgressBar();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            if (dbController == null)
                dbController = masterController.DataBaseController;

            btnLogin.Enabled = false;
            
        }
    }
}
