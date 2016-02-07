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
    public partial class SupplierControl : MyUserControl, IContentPage, IKeyController
    {
        public SupplierControl()
        {
            InitializeComponent();
        }

        public SupplierControl(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
        }

        public Bitmap accessImage
        {
            get
            {
               return Properties.Resources.inventoryWhite; 
            }
        }

        public Menu accessMenuName
        {
            get
            {
                return Menu.Supplier;
            }
        }

        public KeyFunction getKeyController
        {
            get
            {
                return new KeyFunction(SupplierKeyFunction);
            }
        }

        public void SupplierKeyFunction(KeyEventArgs e)
        {

        }

        public void finalizePage()
        {

        }

        public void initializePage()
        {
            dbController = masterController.DataBaseController;
            List<string> listOfSupplier = dbController.supplierMapper.getSupplierList();
            listBox1.Items.AddRange(listOfSupplier.ToArray());    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SupplierControl_Load(object sender, EventArgs e)
        {
       
        }
    }
}
