using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    /* The class that links and manipulates the mainForm & its Controls.
     * Central communication of all MyUserControl
     */
    public class MasterController
    {
        /* EventHandler */
        public event EventHandler<ContentArgs> ContentChange;
        public event EventHandler<EmployeeArgs> EmployeeLogin;
        public event EventHandler EmployeeLogout;
        public event EventHandler ServerClock;

        /* Fields */
        private frmMain mainForm;
        private Panel mainPanel;
        private MenuBar menuBar;
        private Titlebar titleBar;

        private MyUserControl currentContent;
        private UserSettingsControl userSettingsControl;
        private DatabaseController databaseController;

        /* Properties */
        public Employee LoginEmployee { get; set; }
        public Client client { get; set; }

        void startClient()
        {
            string ipAddress = "192.168.43.133";
            client = new Client(ipAddress);
            client.ServerReply += client_ServerReply;
        }

        public void speak(string message)
        {
            if(client != null)
                client.Speak(message);
        }

        public void clientClock()
        {
            speak("1");
        }

        void client_ServerReply(object sender, EventArgs e)
        {
            OnServerClock(new EventArgs());
        }

        public DatabaseController DataBaseController 
        {
            get
            {
                return databaseController;
            }
            set
            {
                databaseController = value;
                databaseController.masterController = this;
            }
        }
        public MyUserControl getCurrentContent
        {
            get { return currentContent; }
        }
        public Titlebar setTitleBar
        {
            set { titleBar = value; }
        }
        public MenuBar setMenuBar
        {
            set { menuBar = value; }
        }

        public UserSettingsControl setUserSettingsControl
        {
            set { userSettingsControl = value; }
        }
        public MyUserControl accessCurrentContent
        {
            get { return currentContent; }
            private set { currentContent = value; }
        }
        public Button setFormReturnkey
        {
            set { mainForm.AcceptButton = value; }
        }

        // Constructor
        public MasterController(frmMain mainForm, Panel mainPanel)
        {
            this.mainForm = mainForm;
            this.mainPanel = mainPanel;
           // startClient();
        }


        public void changeCurrentContent(IContentPage content)
        {
            IContentPage lastContent = currentContent as IContentPage;
            if (lastContent != null)
                lastContent.finalizePage();

            if (content is MyUserControl)
            {
                currentContent = content as MyUserControl;
                currentContent.appear(DockStyle.Fill, mainPanel);

                ContentArgs e = new ContentArgs(content);
                OnContentChange(e);
            }
            content.initializePage();
        }

        /* Event Trigger */
        protected void OnContentChange(ContentArgs e)
        {
            EventHandler<ContentArgs> onContentChange = ContentChange;
            if (onContentChange != null)
                onContentChange(this, e);
        }

        public void OnEmployeeLogin(EmployeeArgs e)
        {
            EventHandler<EmployeeArgs> onEmployeeLogin = EmployeeLogin;
            if (onEmployeeLogin != null)
                onEmployeeLogin(this, e);
            LoginEmployee = e.employee;
        }

        public void OnEmployeeLogout(EventArgs e)
        {
            EventHandler onEmployeeLogout = EmployeeLogout;
            if (onEmployeeLogout != null)
                onEmployeeLogout(this, e);
        }

        private void OnServerClock(EventArgs e)
        {
            EventHandler onServerClock = ServerClock;
            if (onServerClock != null)
                onServerClock(this, e);
        }

        /// <summary>
        /// the method logout() will call the returnHome() method in UserSettingsControl,
        /// which will eventually raise the OnUserLogout Event
        /// </summary>
        /// <returns> returns true if success </returns>

        public bool logout()
        {       
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes){
                userSettingsControl.returnHome();
                return true;
            }
            return false;
        }

        public void closeForm()
        {
            mainForm.Close();
        }

        public void toogleMaximize()
        {
            mainForm.WindowState = 
                (mainForm.WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
            if(mainForm.WindowState == FormWindowState.Normal)
                mainForm.Location = new Point((SystemInformation.PrimaryMonitorSize.Width - mainForm.Width) / 2, (SystemInformation.PrimaryMonitorSize.Height - mainForm.Height) / 2);
        }

        public void moveForm()
        {
            mainForm.moveForm();
        }

        public void mimimizeForm()
        {
            mainForm.WindowState = FormWindowState.Minimized;
        }

        public void updateTitle(Menu menuname, Bitmap icon)
        {
            titleBar.updateTitle(menuname, icon);
        }

        public void showUserSettingsControl()
        {
            userSettingsControl.appearWithUser(LoginEmployee);
        }

        public void appearSideAndSubBar(){
            mainForm.activateTrueForm();
        }

        public void hideSideAndSubBar()
        {
            mainForm.hideTrueForm();
        }

        public void disableForm()
        {
            mainForm.disableForm();
        }

        public Form getFrmMain { get { return mainForm; } }
        public void reloadUsers()
        {
            //
        }
    }
}
