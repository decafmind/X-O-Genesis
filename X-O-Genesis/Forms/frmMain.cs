using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace PetvetPOS_Inventory_System
{
    /* The Primary Form where the program execution starts. */
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /* Fields */
        private MasterController masterController;
        private MenuBar menuBar;
        private LoginPane loginPane;

        private Titlebar titleBar;
        private UserSettingsControl userSettingsControl;
        private KeyFunction keyFunction;
        private bool isLogin = false;

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

        public frmMain()
        {
            InitializeComponent();
            // Initialize the panels 
            masterController = new MasterController(this, mainPanel);
            titleBar = new Titlebar(panelHeader, masterController);
            menuBar = new MenuBar(panelSidebar, masterController);
            userSettingsControl = new UserSettingsControl(userControlPanel, masterController);
            loginPane = new LoginPane(masterController);
            back1.accessMasterController = masterController;
         

            // EventHandler hooking
            masterController.EmployeeLogin += masterController_EmployeeLogin;
            masterController.EmployeeLogout += masterController_EmployeeLogout;
            masterController.ContentChanged += new EventHandler<ContentArgs>(masterController_ContentChange);

            // Initialize DatabaseController
            try
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += worker_DoWork;
                worker.RunWorkerAsync();
            }
            catch (InvalidOperationException iex)
            {
                ErrorLog.Log(iex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }

            displayOnSmall();

            // Avoid flickering
            MyExtension.Graphics_.avoidPanelFlickering(mainPanel);
        }

        /// <summary>
        /// Method that initialize the DatabaseController
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            masterController.DataBaseController = new DatabaseController(masterController);
        }

        void displayOnSmall()
        {
            dateAndTime1.setForeColor(Color.White);
            MinimumSize = new Size(700, 400);
            Size = new Size(700, 400);

            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            Location = new Point((SystemInformation.PrimaryMonitorSize.Width - Width) / 2, (SystemInformation.PrimaryMonitorSize.Height - Height) / 2);
        }

        void displayOnRealSize()
        {
            MinimumSize = new Size(1000, 736);
            Size = new Size(1000, 736);
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;

        }

        void masterController_EmployeeLogin(object sender, EmployeeArgs e)
        {
            dateAndTime1.setForeColor(Color.Black);
            masterController.setFormReturnkey = null;
            isLogin = true;
            displayOnRealSize();
        }

        void masterController_EmployeeLogout(object sender, EventArgs e)
        {
            dateAndTime1.setForeColor(Color.White);
            hideTrueForm();
            initLogin();
            isLogin = false;
            displayOnSmall();
        }

        // This will be call upon content change
        void masterController_ContentChange(object sender, ContentArgs e)
        {
            keyFunction = null;
            if (e.currentContent is IKeyController)
            {
                IKeyController keyController = e.currentContent as IKeyController;
                keyFunction = keyController.getKeyController;
            }

            if (masterController.history.Count == 0)
                back1.enable(false);
            else
                back1.enable(true);
        }

        void initLogin()
        {
            masterController.changeCurrentContent(loginPane, false);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            initLogin();
        }

        // This method change the backColor of SideBar and SubBar into their designated true Color
        public void activateTrueForm()
        {
            panelSidebar.BackColor = Properties.Settings.Default.sidebarColor;
            subHeader.BackColor = Color.Silver;
            back1.Visible = true;
        }        

        // This method is the antithesis of activateTrueForm method
        public void hideTrueForm()
        {   
            panelSidebar.BackColor = Color.White;
            subHeader.BackColor = Color.White;
            back1.Visible = false;
        }

        public void disableForm()
        {
            panelSidebar.BackColor = Color.WhiteSmoke;
            subHeader.BackColor = Color.WhiteSmoke;
            mainPanel.BackColor = Color.WhiteSmoke;
            userControlPanel.BackColor = Color.WhiteSmoke;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isLogin){
                if (!masterController.logout()){
                    e.Cancel = true;
                    base.OnFormClosing(e);
                    return;
                }
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
                masterController.toogleMaximize();
            else if (e.Alt && e.KeyCode == Keys.Left)
                masterController.returnToPreviousPage();

            if (isLogin){
                if (e.Control && e.Shift && e.KeyCode == Keys.L){
                    masterController.logout();
                }
                else if (e.Alt && (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma)){
                    KeyFunction menuBarKeyFunction = menuBar.getMenuBarKeyFunction;
                    menuBarKeyFunction(e);
                }
            }

            if (keyFunction != null)
                keyFunction(e);
            
        }

        public void moveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
