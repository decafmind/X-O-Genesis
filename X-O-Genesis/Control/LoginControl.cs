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
    public partial class LoginControl : MyUserControl
    {
        private User user;
        private LoginPane loginPane;
        private int loginAttempt = 0;
        modalFallback fallback;

        private string Username;
        private string Password;

        public LoginControl() { InitializeComponent(); }

        public LoginControl(LoginPane loginPane, MasterController masterController, Panel panel)
            : base(masterController, panel, true)
        {
            InitializeComponent();
            this.loginPane = loginPane;
            base.masterController.EmployeeLogout += masterController_EmployeeLogout;
            txtUsername.ForeColor = SystemColors.posGray;
            txtUsername.Text = "Enter your username";
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            
            txtPassword.ForeColor = SystemColors.posGray;
            txtPassword.PasswordChar = '*';
            txtPassword.Clear();
            txtPassword.Text = "Enter your password";
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                txtUsername.Text = "Enter your username";
                txtUsername.ForeColor = SystemColors.posGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                txtPassword.Text = "Enter your password";
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = SystemColors.getColorFromArgb(0, 0, 0);
            }
        }
           

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your password")
            {

                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
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
            btnForgot.Enabled = true;
            masterController.setFormReturnkey = btnLogin;
            accessLoginMessage = "Welcome! You may now login";

            loginAttempt = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e){
            btnForgot.Enabled = false;
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
                
                // Disable the Sales Order when on simple/convenience mode
                if (dbController.systemSettingsMapper.isInSimpleMode() && user.getUserLevel() == UserLevel.STAFF)
                {
                    denyLogin();
                    btnLogin.Enabled = true;
                    btnForgot.Enabled = true;
                    return;
                }

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
                btnForgot.Enabled = true;
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

            if (t.Text.Length > 0)
            {
                t.SelectionStart = t.Text.Length;
                t.SelectionLength = 0;
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
            fallback = new modalFallback(dbController);
            fallback.ShowDialog();
        }

        private void lblWelcomeMsg_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            Validation.filterToAlphaNumeric(sender as TextBox);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
