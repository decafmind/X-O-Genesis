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
            if (e.KeyCode == Keys.F1)
                viewSupplier();
            else if (e.Shift && e.KeyCode == Keys.F2)
                removeSupplier();
            else if (e.KeyCode == Keys.F2)
                updateSupplier();
            else if (e.KeyCode == Keys.F3)
                addSupplier();
        }

        public void finalizePage()
        {

        }

        public void initializePage()
        {
            listSupplier();
        }

        private void listSupplier()
        {
            listBox1.Items.Clear();
            List<string> listOfSupplier = dbController.supplierMapper.getSupplierList();
            listBox1.Items.AddRange(listOfSupplier.ToArray());   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SupplierControl_Load(object sender, EventArgs e)
        {
       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewSupplier();
        }

        private void viewSupplier()
        {
            string selected = listBox1.Text;
            if (!string.IsNullOrWhiteSpace(selected))
            {
                Supplier supplier = dbController.supplierMapper.getSupplierByName(selected);
                SupplierView view = new SupplierView(masterController, panelCanvas);
                view.viewSupplier(supplier);
            }
            
        }

        private void updateSupplier()
        {
            if (!string.IsNullOrEmpty(listBox1.Text))
            {
                UpdateSupplier updateSupplier = new UpdateSupplier(masterController, panelCanvas);
                Supplier supplier = dbController.supplierMapper.getSupplierByName(listBox1.Text);
                updateSupplier.mapSupplier(supplier);
            }
        }

        private void addSupplier()
        {
            AddSupplier add = new AddSupplier(masterController, panelCanvas);
            add.SupplierAdded += add_SupplierAdded;
        }

        void add_SupplierAdded(object sender, EventArgs e)
        {
            listSupplier();
        }

        private void removeSupplier()
        {
            int id = dbController.supplierMapper.getSupplierIdByName(listBox1.Text);
            if (id != 0)
                dbController.supplierMapper.removeSupplier(id);
            listSupplier();
        }
    }
}
