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
            loadTable();
        }

        private void loadTable(bool filtered = false, string supplier = "ALL")
        {
            DataTable dt = new DataTable();
            if (filtered)
            {
                if (supplier == "ALL")
                    dbController.productReturnViewMapper.loadTable(dt);
                else
                    dbController.productReturnViewMapper.loadTable(dt, string.Format("supplier = '{0}'", supplier));
            }
            else
            {
                dbController.productReturnViewMapper.loadTable(dt);
            }
            dataGridView1.DataSource = dt;
        }

        private void listSupplier()
        {
            cbSupplier.Items.Clear();
            List<string> listOfSupplier = dbController.supplierMapper.getSupplierList();
            cbSupplier.Items.AddRange(listOfSupplier.ToArray());
            cbSupplier.Items.Add("ALL");
        }

        public void initializePage()
        {
            listSupplier();
        }

        public void finalizePage()
        {

        }

        public Menu accessMenuName
        {
            get
            {
                return Menu.Product_Return;
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

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string supplier = cbSupplier.Text;
            loadTable(true, supplier);
        }

    }
}
