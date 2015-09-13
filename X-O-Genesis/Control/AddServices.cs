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
    public partial class AddServices : MyUserControl
    {
        public event EventHandler paneClose;
        public event EventHandler SubTotalCompute;
        public int Qty { get; set; }

        private Point newLocation;
        public DatabaseController dbController;
        List<Grooming> groomings;
        public decimal Subtotal { get; private set; }

        private bool activated;

        public string getServiceNameSize()
        {
            if (!string.IsNullOrWhiteSpace(cbSize.Text))
                return cbService.Text + " " + cbSize.Text.Substring(0, 1);
            else
                return cbService.Text;
        }

        public bool inConlusion()
        {
            if (Subtotal != 0)
                return true;
            else
                return false;
        }

        public void activate(bool flag)
        {
            activated = flag;

            txtDiscount.Enabled = flag;
            txtPrice.Enabled = flag;
            txtQty.Enabled = flag;
            txtSubtotal.Enabled = flag;

            cbService.Enabled = flag;
            cbSize.Enabled = flag;
            rbGrooming.Enabled = flag;
            rbMedical.Enabled = flag;
        }

        public void reset()
        {
            Subtotal = 0;
            Qty = 0;

            txtDiscount.Text = "0";
            txtPrice.Clear();
            txtQty.Clear();
            txtSubtotal.Clear();

            cbSize.Items.Clear();
            cbService.ResetText();
            cbSize.ResetText();
        }

        public AddServices()
        {
            InitializeComponent();
        }

        public AddServices(MasterController masterController, Panel panel)
            : base(masterController, panel, false)
        {
            InitializeComponent();
            dbController = masterController.DataBaseController;
            initLayoutPanel();
            activate(false);
        }

        void initLayoutPanel()
        {
            int equallyDividedWidth = Width / 3;
            leftPanel.Width = equallyDividedWidth;
            panelRight.Width = equallyDividedWidth;
        }

        public Point NewLocation
        {
            get
            {
                return newLocation;
            }
            set
            {
                newLocation = value;
                animate();
            }
        }

        void getListOfMedicalServices()
        {
            cbService.Items.Clear();
            cbService.Items.AddRange(dbController.getListOfMedical().ToArray());
            txtPrice.ReadOnly = false;
            cbSize.Enabled = false;
            txtPrice.Focus();
        }

        void getListOfGroomingServices()
        {
            groomings = dbController.getListOFGrooming();
            cbService.Items.Clear();
            cbService.Items.AddRange(groomings.ToArray());

            txtPrice.ReadOnly = true;
            cbSize.Enabled = true;
            string[] sizes = new string[] { "SMALL", "MEDIUM", "LARGE" };
            cbSize.Items.Clear();
            cbSize.Items.AddRange(sizes);
        }

        public bool insertService(Transaction transaction)
        {
            if (rbGrooming.Checked)
                return dbController.insertGppTransaction(transaction, getGPP(), Qty, Subtotal);
            else
                return dbController.insertMedicalTransaction(transaction, getMedical(), Qty, Subtotal);
        }

        private void AddServices_Load(object sender, EventArgs e)
        {

        }

        private void OnPaneClose(EventArgs e)
        {
            EventHandler onPaneClose = paneClose;
            if (onPaneClose != null)
                onPaneClose(this, e);
        }

        private void OnSubTotalCompute(EventArgs e)
        {
            EventHandler onSubTotalCompute = SubTotalCompute;
            if (onSubTotalCompute != null)
                onSubTotalCompute(this, e);
        }
        
        public void animate()
        {
            if (newLocation != Point.Empty || newLocation != Location){  
                timer1.Start();
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Exit();
        }

        public void Exit()
        {
            OnPaneClose(new EventArgs());
            disappear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Location.Y >= newLocation.Y){
                int location = Location.Y - 20;
                if (location <= newLocation.Y)
                    Location = new Point(Location.X, newLocation.Y);
                else
                   Location = new Point(Location.X, location);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            reset();

            if (rbGrooming.Checked)
                getListOfGroomingServices();
            else
                 getListOfMedicalServices();
        }

        private void AddServices_Resize(object sender, EventArgs e)
        {
            initLayoutPanel();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbGrooming.Checked)
               txtPrice.Text =  getGPP().price.ToString();
        }

        GPP getGPP()
        {
            Grooming grooming = dbController.getGroomingFromName(cbService.Text);
            Petsize size = dbController.petsizeMapper.getPetsizeFromName(cbSize.Text);
            GPP gpp = dbController.getGPPFromGroomingSize(grooming, size);
            return gpp;
        }

        Medical getMedical()
        {
            Medical medical = dbController.medicalMapper.getMedicalFromName(cbService.Text);
            return medical;
        }

        private void textChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            string charAllowed = "1234567890.";
            MyExtension.Validation.limitTextbox(textbox, charAllowed);
          
            if (textbox != txtSubtotal)
                computeSubtotal();
        }

       
        void computeSubtotal()
        {
            if (
            !(string.IsNullOrWhiteSpace(txtPrice.Text)
            || string.IsNullOrWhiteSpace(txtQty.Text)
            || string.IsNullOrWhiteSpace(txtDiscount.Text))
            )
            {
                decimal price = Decimal.Parse(txtPrice.Text);
                decimal discount = Decimal.Parse(txtDiscount.Text) / 100;
                Qty = int.Parse(txtQty.Text);
                decimal subtotalWithoutDiscount = (price * Qty);

                decimal subtotalWithDiscount = subtotalWithoutDiscount - (subtotalWithoutDiscount * discount);
                txtSubtotal.Text = string.Format("{0:0.00}", subtotalWithDiscount);
                Subtotal = subtotalWithDiscount;

                OnSubTotalCompute(new EventArgs());
            }   
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            masterController.setFormReturnkey = btnOK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            computeSubtotal();
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            txtDiscount.SelectAll();
        }
    }
}
