using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchlessLib;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.PowerPacks;
namespace PetvetPOS_Inventory_System
{
    public partial class frmWebCam : Form
    {
        // Declarations for making the form draggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private TouchlessMgr touchlessMgr;
        private Camera currentCamera;
        private PictureBox userImage;
        private AddUserPane addUserPane;

        private EarAnimation earAnimation;
        private Form mainForm;

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

        public frmWebCam()
        {
            InitializeComponent();
        }

        public frmWebCam(PictureBox userImage)
        {
            InitializeComponent();
            this.userImage = userImage;
        }

        public frmWebCam(AddUserPane addUserPane)
        {
            InitializeComponent();
            this.addUserPane = addUserPane;
            this.userImage = addUserPane.imageUser;

            mainForm = addUserPane.accessMasterController.getFrmMain;
            mainForm.FormClosing += mainForm_FormClosing;

        }

        void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
        }

        private void frmWebCam_Load(object sender, EventArgs e)
        {
            initCamera();
            earAnimation = new EarAnimation(ovalEarL, ovalEarHoleL, ovalEarR, ovalEarHoleR, earTimer, timer1);
            timer1.Start();
        }

        void initCamera()
        {
            if (touchlessMgr != null || currentCamera !=null)
                finalizeCamera();

            touchlessMgr = new TouchlessMgr();
            
            IList<Camera> cameras = touchlessMgr.Cameras;
            foreach (Camera cam in cameras){
                try{
                    touchlessMgr.CurrentCamera = cam;
                    currentCamera = touchlessMgr.CurrentCamera;
                    currentCamera.OnImageCaptured += currentCamera_OnImageCaptured;
                    break;
                }
                catch (ApplicationException){
                    MessageBox.Show("There's seems error in webcam. Please stop and re-play the camera to troubleshoot.", "Message");
                }
            }
            
        }

        void finalizeCamera()
        {
            if(touchlessMgr != null)
                touchlessMgr.Dispose();
            if(currentCamera != null)
                currentCamera.Dispose();
        }

        void currentCamera_OnImageCaptured(object sender, CameraEventArgs e)
        {
            pictureBox1.BackgroundImage = currentCamera.GetCurrentImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPictureViewer.BackgroundImage = currentCamera.GetCurrentImage();
        }

        private void frmWebCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            finalizeCamera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mainPictureViewer.BackgroundImage == null)
            {
                MessageBox.Show("You need to capture image first before you try to save.");
                return;
            }

            addUserPane.ImageOfUser = Randy.GraphicsLibrary.Renderer.resizeImage(mainPictureViewer.BackgroundImage as Bitmap, userImage.Width, userImage.Height);
            userImage.Image = addUserPane.ImageOfUser;
            addUserPane.hasPictureChanged = true;
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            finalizeCamera();
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            initCamera();
        }

        public void moveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void frmWebCam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                moveForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        class EarAnimation
        {
            private OvalShape ovalEarL, ovalEarR, ovalEarHoleL, ovalEarHoleR;
            private Timer timer, backTimer;
            private int count = 0;
            private bool flag = false;

            public EarAnimation(OvalShape ovalEarL, OvalShape ovalEarHoleL, OvalShape ovalEarR, OvalShape ovalEarHoleR, Timer timer, Timer backTimer)
            {
                this.ovalEarL = ovalEarL;
                this.ovalEarHoleL = ovalEarHoleL;
                this.ovalEarR = ovalEarR;
                this.ovalEarHoleR = ovalEarHoleR;

                this.timer = timer;
                this.backTimer = backTimer;
            }

            public void animate()
            {
                int SMALL_ICON_MOVEMENT;

                SMALL_ICON_MOVEMENT = flag ? -5 : 5;

                ovalEarHoleL.Location = new Point(ovalEarHoleL.Location.X - SMALL_ICON_MOVEMENT, ovalEarHoleL.Location.Y + SMALL_ICON_MOVEMENT);
                ovalEarL.Location = new Point(ovalEarL.Location.X - SMALL_ICON_MOVEMENT, ovalEarL.Location.Y + SMALL_ICON_MOVEMENT);
                ovalEarHoleR.Location = new Point(ovalEarHoleR.Location.X + SMALL_ICON_MOVEMENT, ovalEarHoleR.Location.Y + SMALL_ICON_MOVEMENT);
                ovalEarR.Location = new Point(ovalEarR.Location.X + SMALL_ICON_MOVEMENT, ovalEarR.Location.Y + SMALL_ICON_MOVEMENT);

                flag = !flag;
                this.count++;

                if (count == 5)
                {
                    this.count = 0;
                    timer.Stop();
                    backTimer.Start();
                }
            }

        }

        private void earTimer_Tick(object sender, EventArgs e)
        {
            earAnimation.animate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            earTimer.Start();
            timer1.Stop();
        }

        private void frmWebCam_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mainPictureViewer.BackgroundImage = currentCamera.GetCurrentImage();
            }
        }

        private void pawPrint1_Load(object sender, EventArgs e)
        {

        }

    }
}
