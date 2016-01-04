using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Randy.GraphicsLibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MyExtension;

namespace PetvetPOS_Inventory_System
{
    public partial class AddUserPane : MyUserControl
    {
        Employee currentEmployee;
        UserAdministration userAdministration;
        DatabaseController dbController;
        UserAdminMode mode;

        bool isDirty = false;
        string defaultMessage = "";
        List<TextBox> textboxes;
        private Bitmap imageOfUser;

        string imagePath = "";
        public bool hasPictureChanged;

        public Bitmap ImageOfUser
        {
            get
            {
                return imageOfUser;
            }
            set
            {
                imageOfUser = value;
                txtImagepath.Text = imagePath;
            }
        }

        public bool IsDirty { 
            get 
            {
                if (isAllBlank())
                    isDirty = false;

                return isDirty;
            }     
        }

        public AddUserPane()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        public AddUserPane(Panel panel, MasterController masterController, UserAdministration userAdministration)
            : base(masterController, panel, true)
        {
            InitializeComponent();
            this.userAdministration = userAdministration;

            textboxes = new List<TextBox>()
            {
                txtUsername,
                txtPassword,
                txtLastname,
                txtFirstname,
                txtMiddlename,
                txtMobno,
                txtAddress,
                txtRepassword,
                txtAnswer,
            };

            dbController = masterController.DataBaseController;
        }

        private void saveImage()
        {
            try
            {
                string destFolder = @"C:\Petvet\Images\";
                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);

                Random random = new Random();
                imagePath = destFolder + random.Next(1000) + DateTime.Now.Millisecond.ToString() + ".jpg";
                txtImagepath.Text = imagePath;

                using (Bitmap image = imageOfUser as Bitmap)
                {
                    image.Save(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in saving image");
            }
        }


        public void clearTextboxes()
        {
            foreach (TextBox text in textboxes)
                text.Clear();

            domainPosition.Text = "Cashier";
            imageUser.Image = null;
            isDirty = false;
        }

        protected override void doBeforeDisappearance()
        {
            clearTextboxes();
            base.doBeforeDisappearance();
        }

        public void togglePasswordInputs(bool isEnabled)
        {
            txtUsername.Enabled = isEnabled;
            txtPassword.Enabled = isEnabled;
            lblPassword.Visible = isEnabled;
            lblRepassword.Visible = isEnabled;

            txtPassword.Visible = isEnabled;
            txtRepassword.Enabled = isEnabled;
            txtRepassword.Visible = isEnabled;
            lblRepassword.Visible = isEnabled;

            lblAsterisk1.Visible = isEnabled;
            lblAsterisk2.Visible = isEnabled;
            lblAsterisk3.Visible = isEnabled;
        }

        public void init(UserAdminMode mode)
        {
            txtFirstname.Focus();
            masterController.setFormReturnkey = btnSave;
            this.mode = mode;
            hasPictureChanged = false;

            if (mode == UserAdminMode.Add_user)
            {
                clearTextboxes();
                loadSqueryList();
                togglePasswordInputs(true);
                updateStatus("You are creating a New User", SystemColors.menuLightBlue);
            }
            else if (mode == UserAdminMode.Edit_user)
            {
              
                loadSqueryList();
                togglePasswordInputs(false);
                updateStatus("You are updating an Existing User", SystemColors.menuBarBlue);
                currentEmployee = userAdministration.selectedEmployee;
                cmbSquery.SelectedIndex = dbController.getSqueryFromID(currentEmployee.User_id) - 1;

                txtLastname.Text = currentEmployee.Lastname;
                txtFirstname.Text = currentEmployee.Firstname;
                txtMiddlename.Text = currentEmployee.MiddleName;
                txtMobno.Text = currentEmployee.MobileNo;

                txtUsername.Text = currentEmployee.User_id;
                txtImagepath.Text = currentEmployee.ImagePath;
                txtAddress.Text = currentEmployee.Address;
                domainPosition.Text = currentEmployee.Position.ToString();



                if (File.Exists(currentEmployee.ImagePath))
                    imageUser.Image = Renderer.resizeImage(Image.FromFile(currentEmployee.ImagePath) as Bitmap, imageUser.Width, imageUser.Height) as Image;
                else
                    imageUser.Image = null;
            }
        }

        private void upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*jpeg;*.png";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = @fileDialog.FileName;
                imageOfUser = Image.FromFile(filename) as Bitmap;
                imageUser.Image = Renderer.resizeImage(imageOfUser, imageUser.Width, imageUser.Height);
                txtImagepath.Text = filename;

                hasPictureChanged = true;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validation.isFilled(panel_AddUser))
            {
                if (userAdministration.usernames.Contains(txtUsername.Text) && mode != UserAdminMode.Edit_user)
                {
                    MessageBox.Show(String.Format("The username {0} did already exists!", txtUsername.Text));
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                    return;
                }
                else if (txtPassword.Text != txtRepassword.Text)
                {
                    MessageBox.Show("Passwords didn't match!");
                    txtPassword.Focus();
                    txtRepassword.Clear();
                    return;
                }

                if (hasPictureChanged)
                    saveImage();

                User user = new User()
                {
                    UserId = txtUsername.Text,
                    Password = txtPassword.Text,
                    userLevel = domainPosition.Text,
                    Squery = SelectedIndex(cmbSquery.SelectedIndex),
                    FBAnswer = txtAnswer.Text,
                };

                Employee employee = new Employee(user)
                {
                    Firstname = txtFirstname.Text,
                    MiddleName = txtMiddlename.Text,
                    Lastname = txtLastname.Text,
                    MobileNo = txtMobno.Text,
                    EmailAddress = textBox2.Text,
                    TelNo = txtTelno.Text,
                    ImagePath = txtImagepath.Text,
                    Address = txtAddress.Text
                };

                MessageBanner banner;
                if (mode == UserAdminMode.Add_user)
                {
                    dbController.createUserEmployee(user, employee);
                    banner = new MessageBanner(string.Format("New User was added: {0}", user.UserId), 2000);
                    banner.Show();

                    // audit
                    string action = string.Format("added new User {0}", user.UserId);
                    dbController.insertAuditTrail(action);
                }
                else if (mode == UserAdminMode.Edit_user)
                {
                    dbController.updateEmployee(currentEmployee, employee);
                    banner = new MessageBanner(String.Format("User {0} was updated", employee.User_id), 2000);
                    banner.Show();

                    // audit
                    string action = string.Format("updated User {0}", employee.User_id);
                    dbController.insertAuditTrail(action);
                }

                this.disappear();
            }

            else
            {
                MessageBanner banner = new MessageBanner("Please fill up all the fields and try again.", 2000);
                banner.BackColor = System.Drawing.Color.DarkRed;
                banner.ForeColor = System.Drawing.Color.White;
                banner.Opacity = 1;
                banner.Show();
            }
         
        }

        private bool isAllBlank()
        {
            foreach (TextBox textbox in textboxes)
            {
                if (!String.IsNullOrEmpty(textbox.Text))
                    return false;
            }
            return true;
        }


        private void textboxes_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string acceptedChar;
            if (t == txtMobno)
                acceptedChar = "1234567890-+";
            else if (t == txtFirstname || t == txtMiddlename || t == txtLastname)
                acceptedChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
            else
                acceptedChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890 ";

            Validation.limitTextbox(sender as TextBox, acceptedChar);

            if (t == txtUsername){
                if ((userAdministration.usernames.Contains(txtUsername.Text)) && 
                    (userAdministration.mode != UserAdminMode.Edit_user)){
                    vUsername.Visible = true;
                    updateStatus(String.Format("username: {0} already exists", txtUsername.Text), Color.Red);
                }else{
                    vUsername.Visible = false;
                    updateStatus("reset");
                }
            }else if (sender as TextBox == txtRepassword){
                if (txtPassword.Text == txtRepassword.Text || String.IsNullOrEmpty(txtRepassword.Text)){
                    vRepassword.Visible = false;
                    updateStatus("reset");
                }else{
                    vRepassword.Visible = true;
                    updateStatus("password does not match", Color.Red);
                }
            }
        }

        void updateStatus(string message, Color color)
        {
            if (message.Contains("User")){
                defaultMessage = message;
            }
            else if (message.Contains("reset")){
                message = defaultMessage;
                if (message.Contains("New"))
                    color = SystemColors.menuLightBlue;
                else if (message.Contains("updating"))
                    color = SystemColors.menuBarBlue;
            }
            lblMode.Text = message;
            lblMode.BackColor = color;
        }

        void updateStatus(string message){
            updateStatus(message, Color.Transparent);
        }

        private void button1_Click_1(object sender, EventArgs e){   
            frmWebCam webCam = new frmWebCam(this);
            webCam.Show();
        }

        private void filterNames(object sender, EventArgs e)
        {
            Validation.filterToNames(sender as TextBox);
        }
        private void filterContacts(object sender, EventArgs e)
        {
            Validation.filterToContactNo(sender as TextBox);
        }
        private void filterEmail(object sender, EventArgs e)
        {
            Validation.filterToEmail(sender as TextBox);
        }
        private void filterParagraph(object sender, EventArgs e)
        {
            Validation.filterToParagraph(sender as TextBox);
        }
        private int SelectedIndex(int index)
        {
            int findex = 0;
            findex = index + 1;
            return findex;
        }
        public void loadSqueryList()
        {
            cmbSquery.Items.Clear();
            cmbSquery.Items.AddRange(dbController.getListOfSquery().ToArray());
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cmbSquery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void vUsername_Load(object sender, EventArgs e)
        {

        }

        private void vRepassword_Load(object sender, EventArgs e)
        {

        }

        private void lblRepassword_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtImagepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void domainPosition_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
    }
}
