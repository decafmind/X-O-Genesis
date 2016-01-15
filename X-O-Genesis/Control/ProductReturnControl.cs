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
    public partial class ProductReturnControl : MyUserControl, IContentPage, IKeyController
    {
        public ProductReturnControl()
        {
            InitializeComponent();
        }

        public ProductReturnControl(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
        }

        private void ProductReturnControl_Load(object sender, EventArgs e)
        {
            ProductReturnMapper productReturnedMapper = new ProductReturnMapper(base.masterController.DataBaseController.mySqlDB);
            DataTable dt = new DataTable();
            productReturnedMapper.loadTable(dt);
            dataGridView1.DataSource = dt;
        }

        public void initializePage()
        {

        }

        public void finalizePage()
        {

        }

        public Menu accessMenuName
        {
            get
            {
                return Menu.Settings;
            }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.userBlack; }
        }

        public KeyFunction getKeyController
        {
            get
            {
                return null;
            }
        }

    }
}
