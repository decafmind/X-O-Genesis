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
    // Base Class

    public partial class ScrollPane : MyUserControl
    {
        private const int INIT_HEIGHT = 50;
      
        protected bool isVisible = false;
        protected int height;
        protected int maxHeight = 100;

        // A read-only property
        public bool checkIfVisisble 
        {
            get
            {
                return isVisible;
            } 
        }

        public ScrollPane()
        {
            InitializeComponent();
            height = INIT_HEIGHT;
            Size = new Size(Width, height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            animation();
        }

        public virtual void doWhenVisible() {}

        public virtual void doWhenNotVisible() {}

        public void switchOff()
        {
            if (checkIfVisisble)
                toggle();
        }

        public void animation()
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            int width = this.Width;

            if (!isVisible)
            {
                height += 50;
                Size = new Size(Width, height);
                if (height >= maxHeight)
                {
                    isVisible = !isVisible;
                    stopTimer();
                    doWhenVisible();
                }
            }
            else
            {
                height -= 50;
                Size = new Size(Width, height);
                if (height <= 50)
                {
                    isVisible = !isVisible;
                    stopTimer();
                    doWhenNotVisible();
                }
            }
        }

        public void toggle()
        {
            startTimer();
        }

        public ScrollPane(MasterController masterController, Panel panel, DockStyle dockStyle):base(masterController, panel,dockStyle)
        {
            InitializeComponent();
            height = INIT_HEIGHT;
            Size = new Size(Width, INIT_HEIGHT);
        }

        private void ScrollPane_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            animation();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            animation();
        }

        protected void startTimer()
        {
            timer2.Start();
        }

        protected void stopTimer()
        {
            timer2.Stop();
        }
    }
}
