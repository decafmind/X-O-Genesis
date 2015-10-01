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
    public partial class ServiceScrollPane : ScrollPane
    {
        DatabaseController dbController;
        InventoryView inventoryView;
        Grooming origGrooming, grooming;
        GPP origGPP;
        Medical origMedical, medical;

        bool onUpdateMode;

        public ServiceScrollPane(){
            InitializeComponent();
        }

        public override void doWhenVisible()
        {
            base.doWhenVisible();

            if (rbGrooming.Checked){
                enablePriceAndSize(true);
                if (onUpdateMode)
                    cbSize.Enabled = false;
            }
            else{
                enablePriceAndSize(false);
            }

            if (onUpdateMode)
            {
                rbGrooming.Enabled = false;
                rbMedical.Enabled = false;
            }
            else
            {
                rbGrooming.Enabled = true;
                rbMedical.Enabled = true;
            }
            masterController.setFormReturnkey = button1;
        }

        public ServiceScrollPane(InventoryView inventoryView, Panel panel, MasterController masterController)
            : base(masterController, panel, DockStyle.Bottom)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
            this.inventoryView = inventoryView;
            base.maxHeight = 215;
        }

        public void toogleInsert()
        {
            toggle();
            onUpdateMode = false;
            clear();
        }

        public void toogleUpdate(Service service)
        {
            toggle();
            onUpdateMode = true;
            if (service is GPP)
                rbGrooming.Checked = true;
            else if (service is Medical)
                rbMedical.Checked = true;

            mappedServiceToFields(service);
        }
        
        void mappedServiceToFields(Service service)
        {
            if (service is GPP)
            {
                origGPP = service as GPP;
                origGrooming = dbController.groomingMapper.getGroomingFromId(origGPP.grooming_id);
                txtName.Text = origGrooming.Name;
                txtPrice.Text = origGPP.price.ToString();
                cbSize.Text = origGPP.petsize.ToString();
            }
            else if (service is Medical)
            {
                origMedical = service as Medical;
                txtName.Text = origMedical.Name;
                rbMedical.Checked = true;
                txtPrice.Clear();
            }
        }

        void updateGrooming()
        {
            grooming = new Grooming(){
                Name =  txtName.Text,
            };

            dbController.updateGrooming(origGrooming, grooming);
            updateGPP(grooming);
        }

        void updateGPP(Grooming grooming)
        {
            GPP gpp = new GPP()
            {
                price = decimal.Parse(txtPrice.Text),
            };

            dbController.updateGPP(origGPP, gpp);
        }

        void updateMedical()
        {
            medical = new Medical()
            {
                Name = txtName.Text,
            };

            dbController.updateMedical(origMedical, medical);
        }

        void insertGrooming() {
            string name = string.Empty;
            decimal price = 0;
            name = txtName.Text;
            price = Decimal.Parse(txtPrice.Text);

            Petsize size = dbController.petsizeMapper.getPetsizeFromName(cbSize.Text);

            if (!checkIfGroomingAlreadyExists(name)){
                
                grooming = new Grooming(){
                    Name = name
                };

                if (dbController.insertGrooming(grooming)){
                    grooming.Id = dbController.getGroomingIDFromName(grooming.Name);
                    dbController.insertGPP(grooming, size, price);
                }               
            }
            else{
                dbController.insertGPP(grooming, size, price);    
            }
        }

        void insertMedical()
        {
            string name = txtName.Text;
            Medical medical = new Medical(name);
            dbController.insertMedical(medical);
        }

        void clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            cbSize.Items.Clear();
            cbSize.ResetText();
        }

        private void ServiceScrollPane_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!onUpdateMode)
            {
                if (rbGrooming.Checked)
                {
                    if (!(string.IsNullOrWhiteSpace(txtName.Text) ||
                            string.IsNullOrWhiteSpace(txtPrice.Text) ||
                            string.IsNullOrWhiteSpace(cbSize.Text)))
                    {
                        insert();
                    }
                }
                else if (rbMedical.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(txtName.Text))
                        insert();
                }
            }
            else
            {
                if (rbGrooming.Checked)
                    updateGrooming();
                else
                    updateMedical();
            }


            if (!cbStayput.Checked)
                toggle();
            else
                txtName.Focus();
        }

        void insert()
        {
            if(rbGrooming.Checked){
                insertGrooming();
            }else if(rbMedical.Checked){
                insertMedical();
            }

            clear();
        }

       
        private void txtChanged(object sender, EventArgs e){
            TextBox textbox = sender as TextBox;
            string allowedChar = string.Empty;

            if (textbox == txtName)
                allowedChar = "&ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz 1234567890&\\/+";
            else if (textbox == txtPrice)
                allowedChar = "1234567890.";

            MyExtension.Validation.limitTextbox(textbox, allowedChar);
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked){
                if (rb == rbMedical)
                    enablePriceAndSize(false);
                else if (rb == rbGrooming)
                    enablePriceAndSize(true);
            }
        }

        void enablePriceAndSize(bool flag)
        {
            txtPrice.Enabled = flag;
            cbSize.Enabled = flag;

            if (flag)
                fillCbSize();
            else
                resetCbText();
            
            txtName.Focus();
        }

        void fillCbSize()
        {
            cbSize.Items.Clear();
            string[] items = new string[]{
                    "SMALL",
                    "MEDIUM",
                    "LARGE",
                };
            cbSize.Items.AddRange(items);
        }

        void resetCbText()
        {
            cbSize.Items.Clear();
            cbSize.ResetText();
        }

        
        bool checkIfGroomingAlreadyExists(string name)
        {
            grooming = null;
            grooming = dbController.getGroomingFromName(name);

            if (grooming.Id != 0)
                return true;
            else
                return false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
