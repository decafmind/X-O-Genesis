using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PetvetPOS_Inventory_System
{
    public enum UserAdminMode
    {
        Add_user,
        Edit_user,
        View_user,
        Standby,
    }

    public partial class UserAdministration : MyUserControl, IContentPage, IKeyController
    {
        private AddUserPane addUserPane;
        private UserView userView;
        public Employee selectedEmployee;
        public User seletedUser;
        public UserAdminMode mode = UserAdminMode.Standby;

        private DatabaseController dbController;
        Dictionary<string, Employee> userEmployeeMap = new Dictionary<string, Employee>();
        public List<string> usernames = new List<string>();


        public void changedTab(int index)
        {
            tabControl1.SelectedIndex = index;
            switch (index)
            {
                case 0:
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    break;
                case 1:
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage4);
                    break;
                case 2:
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage3);
                    break;

            }
            
        }

        public void reloadUsers()
        {
            usernames = dbController.getListOfActiveUsernames();
            Employee employee;
            User user;
            userEmployeeMap.Clear();

            foreach (string username in usernames){
                user = dbController.getUserFromId(username);
                employee = dbController.getEmployeeFromUser(user);
                userEmployeeMap.Add(username, employee);
            }

            populateUserListbox();
        }

        private void populateUserListbox()
        {
            lbUsers.Items.Clear();
            lbUsers.Items.AddRange(usernames.ToArray());
        }

        public UserAdministration()
        {
            InitializeComponent();
        }

        public UserAdministration(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
            dbController = masterController.DataBaseController;
        }

        public UserAdministration(MasterController masterController, int index)
            : base(masterController)
        {
            InitializeComponent();
            changedTab(index);
            dbController = masterController.DataBaseController;
        }

        void masterController_EmployeeLogin(object sender, EmployeeArgs e)
        {
           // reloadUsers();
        }

        public void initializePage()
        {
            reloadUsers();
            lbUsers.Text = masterController.LoginEmployee.User_id;

            dbController.InsertEntity += dbController_InsertEntity;
            dbController.UpdateEntity += dbController_UpdateEntity;
            dbController.DeleteEntity += dbController_DeleteEntity;

         //   tabControl1.SelectedIndex = 1;

         //   timer1.Start();
        }
        

        public void finalizePage()
        {
            /* Unhooking event */
            dbController.InsertEntity -= dbController_InsertEntity;
            dbController.UpdateEntity -= dbController_UpdateEntity;
            dbController.DeleteEntity -= dbController_DeleteEntity;
        }

        void dbController_DeleteEntity(object sender, EntityArgs e)
        {
            IEntity entity = e.Entity;
            if (entity is User)
            {
                Employee employee = dbController.getEmployeeFromUser(entity as User);
                try
                {
                    if (File.Exists(employee.ImagePath))
                        File.Delete(employee.ImagePath);
                }
                catch (IOException iex)
                {
                    ErrorLog.Log(iex);
                }
                catch (Exception ex)
                {
                    ErrorLog.Log(ex);
                }

            }

            reloadUsers();
            lbUsers.Text = masterController.LoginEmployee.User_id;
        }

        void dbController_UpdateEntity(object sender, EntityArgs e)
        {
            if (e.Entity is Employee)
            {
                Employee employee = e.Entity as Employee;
                userEmployeeMap[employee.User_id] = employee;
                populateUserListbox();
                lbUsers.Text = employee.User_id;
            }
        }

        void dbController_InsertEntity(object sender, EntityArgs e)
        {
            if (e.Entity is Employee)
            {
                Employee employee = e.Entity as Employee;
                usernames.Add(employee.User_id);
                userEmployeeMap.Add(employee.User_id, employee);
                populateUserListbox();
                lbUsers.Text = employee.User_id;
            }
        }

        // Utility method
        void flipColors()
        {
            Color colorForContentPanel = Color.WhiteSmoke;
            if (mode == UserAdminMode.Add_user || mode == UserAdminMode.Edit_user)
                colorForContentPanel = Color.White;
            contentPanel.BackColor = colorForContentPanel;
        }
  
        public Menu accessMenuName
        {
            get { return Menu.User; }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.usersIcon; }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            addUser();
        }

        void viewUser(){
                try
                {
                    if (addUserPane != null && addUserPane.IsDirty)
                    {
                        DialogResult result = MessageBox.Show("There are seems unsaved work.. Are you sure you want to continue?",
                                                                "You are going to leave unsave work", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.No)
                            return;
                        else
                            addUserPane.clearTextboxes();
                    }

                    if (mode != UserAdminMode.View_user)
                    {
                        userView = new UserView(userPanel, masterController);
                        mode = UserAdminMode.View_user;
                        flipColors();
                    }

                    lbUsers.Focus();
                    selectedEmployee = userEmployeeMap[lbUsers.SelectedItem.ToString()];
                    userView.showUser(selectedEmployee);
                }
                catch (NullReferenceException)
                {
                    if (lbUsers.SelectedItem == null)
                        MessageBox.Show("No selected user.. ");
                }  
        }

        public KeyFunction getKeyController
        {
            get { return new KeyFunction(UserAdmin_KeyFuntion); }
        }

        private void UserAdmin_KeyFuntion(KeyEventArgs e)
        {

            if ((e.Shift && e.KeyCode == Keys.F2) || e.KeyCode == Keys.Delete)
            {
                keyButton4.updateButton();
                keyButton5.updateButton();
                removeUser();
            }
            else if (e.KeyCode == Keys.F1)
            {
                keyButton1.updateButton();
                viewUser();
            }
            else if (e.KeyCode == Keys.F2)
            {
                keyButton2.updateButton();
                editUser();   
            }
            else if (e.KeyCode == Keys.F3)
            {
                keyButton3.updateButton();
                addUser();
            }
        }

        void addUser()
        {
            if (mode != UserAdminMode.Add_user)
            {
                mode = UserAdminMode.Add_user;
                showUserPane();
            }
        }

        void showUserPane()
        {
            if (addUserPane == null)
                addUserPane = new AddUserPane(userPanel, masterController, this);
            else
                addUserPane.appear(DockStyle.Fill);

            addUserPane.init(mode);
            flipColors();
        }

        void removeUser()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Remove user", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                MessageBanner banner = new MessageBanner(String.Format("User {0} has been removed", lbUsers.SelectedItem.ToString()), 3000);
                string userid = lbUsers.SelectedItem.ToString();
                if (dbController.removeUser(dbController.getUserFromId(userid)))
                   banner.Show();

                // audit
                string action = string.Format("removed the User {0}", userid);
                dbController.insertAuditTrail(action);
            }
        }

        void editUser()
        {
            if (mode != UserAdminMode.Edit_user){
                mode = UserAdminMode.Edit_user;
                showUserPane();
            }
        }

        private void UserAdministration_SizeChanged(object sender, EventArgs e)
        {
            userPanel.Location = new Point((Width - (sidePanel.Width + userPanel.Width)) / 2, userPanel.Location.Y);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            viewUser();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                masterController.updateTitle(Menu.AccountSettings, null);
            else if (tabControl1.SelectedIndex == 1)
                masterController.updateTitle(Menu.LoginTrail, null);
            else if (tabControl1.SelectedIndex == 2)
                masterController.updateTitle(Menu.AuditTrail, null);
        }

        private void loginTrail_Load(object sender, EventArgs e)
        {
            loginTrail.cmbEmployee.Items.AddRange(userEmployeeMap.Keys.ToArray());
            loginTrail.cmbEmployee.SelectedIndex = 0;
            filterLoginTrail();

            loginTrail.cmbEmployee.SelectedIndexChanged += cmbEmployee_SelectedIndexChanged;
            loginTrail.dtPicker.ValueChanged += dtPicker_ValueChanged;
        }

        void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            filterLoginTrail();
        }

        void filterLoginTrail()
        {
            if (loginTrail.cmbEmployee.Text == "ALL" || String.IsNullOrWhiteSpace(loginTrail.cmbEmployee.Text)){
                loginTrail.trailGrid.DataSource = dbController.filterLoginTrail(new DataTable(), loginTrail.dtPicker.Value);
            }
            else{
                loginTrail.trailGrid.DataSource = dbController.filterLoginTrailUserAndDate(new DataTable(),
                    loginTrail.cmbEmployee.Text, loginTrail.dtPicker.Value);
            }
        }

        void filterAuditTrail()
        {
            if (auditTrail.cmbEmployee.Text == "ALL" || String.IsNullOrWhiteSpace(auditTrail.cmbEmployee.Text))
            {
                auditTrail.trailGrid.DataSource = dbController.filterAuditTrail(new DataTable(), auditTrail.dtPicker.Value);
            }
            else
            {
                auditTrail.trailGrid.DataSource = dbController.filterAuditTrailUserAndDate(new DataTable(),
                    auditTrail.cmbEmployee.Text, auditTrail.dtPicker.Value);
            }
        }

        void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterLoginTrail();
        }

        void cmbEmployee_SelectedIndexChanged1(object sender, EventArgs e)
        {
            filterAuditTrail();
        }

        void dtPicker_ValueChanged1(object sender, EventArgs e)
        {
            filterAuditTrail();
        }


        private void auditTrail_Load(object sender, EventArgs e)
        {
            auditTrail.cmbEmployee.Items.AddRange(userEmployeeMap.Keys.ToArray());
            auditTrail.cmbEmployee.SelectedIndex = 0;
            filterAuditTrail();

            auditTrail.cmbEmployee.SelectedIndexChanged += cmbEmployee_SelectedIndexChanged1;
            auditTrail.dtPicker.ValueChanged += dtPicker_ValueChanged1;
        }

        void auditTrailWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            filterAuditTrail();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reloadUsers();
        }
    }
}

 

