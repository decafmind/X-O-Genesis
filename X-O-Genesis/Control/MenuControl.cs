using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using Randy.GraphicsLibrary;

namespace PetvetPOS_Inventory_System
{
    public partial class MenuControl : MyUserControl
    {
        private MenuBar menuBar;
        private Menu menu;
        private bool isSelected;
        private IContentPage mapControl;

        private Bitmap iconImage;
        // Reference for the moving ear
        private EarAnimation earAnimation;

        public MenuControl()
        {
            InitializeComponent();
        }

        public MenuControl(IContentPage mapControl, MenuBar menuBar)
        {
            InitializeComponent();
            this.mapControl = mapControl;
            accessMenuBar = menuBar;
            accessIconImage = mapControl.accessImage;
            accessMenuName = mapControl.accessMenuName;
            this.TabStop = false;
        }

        public IContentPage accessMapPanel
        {
            get { return mapControl; }
        }

        public MenuBar accessMenuBar
        {
            set
            {
                menuBar = value;
                accessMasterController = menuBar.accessMasterController;
            }
        }

        public Bitmap accessIconImage 
        {
            get { return new Bitmap(iconImage); }
            private set {
                iconImage = Renderer.resizeImage(value, 47, 47);
                icon.Invalidate();
            }
        }

        public string accessIconLabel
        {
            private set { menuName.Text = value; }
            get { return menuName.Text; }
           
        }

        public Menu accessMenuName
        {
            private set
            {
                menu = value;
                string[] split = menu.ToString().Split('_');
                string polishString = string.Empty;
                int string_length = split.Length;
                for (int i = 0; i < string_length; i++)
                {
                    polishString += split[i];
                    if (i != string_length - 1)
                        polishString += " ";
                        
                }
                accessIconLabel = polishString;
            }
            get { return menu;  }
        }

        private void icon_Click(object sender, EventArgs e)
        {
            activateControl();
        }

        public void activateControl()
        {
            // If already selected, return prematurely
            if (isSelected)
                return;

            // Unselect all menus before selecting new
            menuBar.unselectAll();
            isSelected = true;

            menuBar.updateMenus();
            masterController.changeCurrentContent(mapControl);
        }

        private void icon_MouseHover(object sender, EventArgs e)
        {
            if (!isSelected)
                timer1.Start();
        }

        public void redraw()
        {
            Color DarkBlue = SystemColors.jetBlackTitleBar;
            Color origColor = SystemColors.menuSilver;
            Color white = Color.White;
            Color gold = Color.Gold;

            if (isSelected){
                icon.BackColor = white;
                icon.BorderColor = gold;
                ovalEarL.BorderColor = gold;
                ovalEarR.BorderColor = gold;

                ovalEarHoleL.BackColor = gold;
                ovalEarHoleR.BackColor = gold;
                BackColor = DarkBlue;
                timer1.Start();
            }
            else{
                icon.BackColor = origColor;
                icon.BorderColor = white;
                ovalEarL.BorderColor = white;
                ovalEarR.BorderColor = white;

                ovalEarHoleL.BackColor = white;
                ovalEarHoleR.BackColor = white;
                BackColor = Color.Transparent;
                timer1.Stop();
            }
        }

        public void unselect()
        {
            isSelected = false;
        }

        private void MenuControl_Load(object sender, EventArgs e)
        {
            earAnimation = new EarAnimation(ovalEarL, ovalEarHoleL, ovalEarR, ovalEarHoleR, timer1);
        }

        private void lblDesc_MouseClick(object sender, MouseEventArgs e)
        {
            activateControl();
        }

        private void ovalShape4_Click(object sender, EventArgs e)
        {
            activateControl();
        }

        private void MenuControl_Click(object sender, EventArgs e)
        {
            activateControl();
        }

        // Inner Class for animating the ear

        class EarAnimation
        {
            private OvalShape ovalEarL, ovalEarR, ovalEarHoleL, ovalEarHoleR;
            private Timer timer;
            private int count = 0;
            private bool flag = false;

            public EarAnimation(OvalShape ovalEarL, OvalShape ovalEarHoleL, OvalShape ovalEarR, OvalShape ovalEarHoleR, Timer timer)
            {
                this.ovalEarL = ovalEarL;
                this.ovalEarHoleL = ovalEarHoleL;
                this.ovalEarR = ovalEarR;
                this.ovalEarHoleR = ovalEarHoleR;
                this.timer = timer;
            }

            public void animate()
            {
                int SMALL_ICON_MOVEMENT;

                SMALL_ICON_MOVEMENT = flag ? -3 : 3;
                
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
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            earAnimation.animate();
        }

        private void icon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(iconImage, new Point(22, 32));

        }

        private void menuName_Click(object sender, EventArgs e)
        {

        }

    }
}
