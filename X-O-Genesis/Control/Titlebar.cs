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
using System.Runtime.InteropServices;
using System.IO;

namespace PetvetPOS_Inventory_System
{
    public partial class Titlebar : MyUserControl
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        private Menu defaultMenu = Menu.Login;
        private Bitmap defaultIcon = Properties.Resources.shopIcon;
        private string title;
        private Bitmap imageIcon;

        string companyLogoImagePath = string.Empty;
        Image companyLogo;

        public Titlebar()
        {
            InitializeComponent();
        }

        public Titlebar(Panel panel, MasterController masterController):base(masterController, panel, true)
        {
            InitializeComponent();
            this.masterController = masterController;
            this.masterController.setTitleBar = this;
            this.masterController.ContentChanged += new EventHandler<ContentArgs>(masterController_ContentChange);

            this.masterController.EmployeeLogin += masterController_EmployeeLogin;
            this.masterController.EmployeeLogout += masterController_EmployeeLogout;
            this.masterController.SettingsChanged += masterController_SettingsChanged;
            masterController.getFrmMain.Resize += getFrmMain_Resize;
           
            TabStop = false;
            whenNotLogin();
            initColors();

            companyLogoImagePath = Properties.Settings.Default.CompanyLogoImagPath;
            if (File.Exists(companyLogoImagePath))
                companyLogo = Renderer.resizeImage(Image.FromFile(companyLogoImagePath) as Bitmap, panelImage.Width, panelImage.Height) as Image;

        }

        void initColors()
        {
            panelTitle.BackColor = Properties.Settings.Default.headerColor;
            panel4.BackColor = Properties.Settings.Default.headerColor;
            panelImage.BackColor = Properties.Settings.Default.iconColor;
        }

        void masterController_SettingsChanged(object sender, SettingArgs e)
        {
            if (e.settings == Settings.PERSONALIZATION)
            {
                initColors();
            }
        }

        void getFrmMain_Resize(object sender, EventArgs e)
        {
            panelTitle.Invalidate();
        }

        void masterController_EmployeeLogout(object sender, EventArgs e)
        {
            whenNotLogin();
        }

        void masterController_EmployeeLogin(object sender, EmployeeArgs e)
        {
            whenLogin();
        }

        void whenNotLogin()
        {
            button1.Visible = false;
            button3.Visible = false;
            setImage = defaultIcon;
        }

        void whenLogin()
        {
            button1.Visible = true;
            button3.Visible = true;
        }

        void masterController_ContentChange(object sender, ContentArgs e)
        {
            if (e.currentContent is IContentPage)
            {
              IContentPage foo =  e.currentContent as IContentPage;
              updateTitle(foo.accessMenuName, foo.accessImage);
            }
        }

        public void setDefault(){

            updateTitle(defaultMenu, defaultIcon);
        }

        public string setTitle 
        {
            get
            {
                return title;
            }
            set
            {
                title = value.ToUpper();
                panelTitle.Invalidate();
            }
        }

        public Bitmap setImage
        {
            set
            {
                imageIcon = Renderer.resizeImage(value, panelImage.Width, panelImage.Height);
                panelImage.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            masterController.closeForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            masterController.mimimizeForm();
        }

        public void updateTitle(Menu menuname, Bitmap icon)
        {
            string titlename = "";

            switch (menuname){
                case Menu.POS:
                    titlename = "Point of Sale";
                    break;
                case Menu.AccountSettings:
                    titlename = "Account Settings";
                    break;
                case Menu.AuditTrail:
                    titlename = "Audit Trail";
                    break;
                case Menu.LoginTrail:
                    titlename = "Login Trail";
                    break;
                case Menu.Login:
                    titlename = "EXOGENESIS";
                    break;
                case Menu.Home:
                    titlename = "Dashboard";
                    break;
                case Menu.Sales:
                    titlename = "Sales Report";
                    break;
                case Menu.User:
                    titlename = "User Management";
                    break;
                case Menu.Client:
                    titlename = "Customer Information";
                    break;
                case Menu.Orders:
                    titlename = "Purchase Order";
                    break;
                case Menu.Stock_Control:
                    titlename = "Stock Control";
                    break;
                case Menu.System_Operation:
                    titlename = "System Operation";
                    break;
                default:
                    titlename = menuname.ToString();
                    break;
            }

            setTitle = titlename;
            if (icon != null)
                setImage = icon;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            masterController.toogleMaximize();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            masterController.mimimizeForm();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            masterController.toogleMaximize();
            panelTitle.Invalidate();
            panelImage.Invalidate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            masterController.closeForm();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
     //       button3.BackgroundImage = Properties.Resources.max_;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
    //        button3.BackgroundImage = Properties.Resources.max_ini_;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Font arialRoundedMt = new Font("Arial Rounded MT", 48, FontStyle.Bold)){
                float brightness = panelTitle.BackColor.GetBrightness();
                SizeF stringSize = g.MeasureString(title, arialRoundedMt);
                Brush brush;
                if (brightness > 0.50)
                    brush = Brushes.Black;
                else
                    brush = Brushes.White;
                g.DrawString(title, arialRoundedMt, brush, new PointF((panelTitle.Width - stringSize.Width)/2, 5));
            }
        }

        private void panelImage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (companyLogo!= null)
                g.DrawImageUnscaled(companyLogo, new Point(0, 0));
            else
                g.DrawImageUnscaled(imageIcon, new Point(0, 0));
        }

   
        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){
                masterController.moveForm();
            }
        }

        private void panelTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            masterController.toogleMaximize();
        }

        private void kek(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Close_Window;


        }

        private void kekek(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.Delete1;

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
