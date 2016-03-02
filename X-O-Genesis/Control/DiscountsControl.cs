using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyExtension;

namespace PetvetPOS_Inventory_System
{
    public partial class DiscountsControl : MyUserControl, IContentPage
    {
        DataTable discountsTable = new DataTable();
        Discounts discounts;

        private const int DEFAULT_DISCOUNT_TYPE_PERCENT = 1;
        private const int DEFAULT_DISCOUNT_TYPE_FIXED = 2;
        private const int DEFAULT_FLAG = 1;
        private const int DELETE_FLAG = 0;
       
        private enum Mode
        {
            Add,
            Edit,
            Delete,
            View
        }

        private Mode currentMode;
        private string selectedItem = string.Empty;
        public DiscountsControl(MasterController masterController):base(masterController)
        {
            InitializeComponent();
        }
        public DiscountsControl()
        {
            InitializeComponent();
        }

        public void initializePage()
        {
            dbController.loadDiscounts(discountsTable);
            populateListView(discountsTable);
        }

        void populateListView(DataTable dt)
        {
            lv_Discounts.Items.Clear();
            lv_Discounts.View = View.Details;
            lv_Discounts.Scrollable = true;

            ColumnHeader header = new ColumnHeader();
           
            header.Text = "";
            header.Name = "Discount Titles";
            lv_Discounts.Columns.Add(header);

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["title"].ToString());
                if(!lv_Discounts.Items.Contains(item))
                    lv_Discounts.Items.Add(item);
            }
            
            lv_Discounts.Columns[0].Width = -2;
        }

        public void finalizePage()
        {
            
        }

        public Menu accessMenuName
        {
            get
            {
                return Menu.Discounts;
            }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.Banknotes; }
        }

        private void lv_Discounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "***Preview***";
            currentMode = Mode.View;
            changeFieldStatus(false);

            getSelectedItemFromList(lv_Discounts);
            if (!string.IsNullOrEmpty(selectedItem))
            {
                fillDiscountDetails(selectedItem);
            }
        }

        void getSelectedItemFromList(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                selectedItem = lv.SelectedItems[0].SubItems[0].Text;
            }
        }

        void fillDiscountDetails(string item)
        {
            discounts = new Discounts();
            int type;

            discounts = dbController.discountsMapper.getDiscountDetailsFromTitle(item);

            type = discounts.Type;
            txtTitle.Text = discounts.Title;
            txtDesc.Text = discounts.Desc;
            txtLess.Text = discounts.Less.ToString();
            if (type == 1)
            {
                radio_Percent.Checked = true;
                radio_Fixed.Checked = false;
                radio_Percent.Font = new Font(radio_Percent.Font, FontStyle.Bold);
                radio_Fixed.Font = new Font(radio_Fixed.Font, FontStyle.Regular);
            }
            else if (type == 2)
            {
                radio_Percent.Checked = false;
                radio_Fixed.Checked = true;
                radio_Fixed.Font = new Font(radio_Fixed.Font, FontStyle.Bold);
                radio_Percent.Font = new Font(radio_Percent.Font, FontStyle.Regular);
            }

        }
        void changeFieldStatus(bool status)
        {
            txtTitle.Enabled = status;
            txtDesc.Enabled = status;
            txtLess.Enabled = status;
            group_Type.Enabled = status;
            btnSave.Visible = status;
        }

        void clearFields()
        {
            txtTitle.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtLess.Text = string.Empty;
            group_Type.Text = string.Empty;
            lv_Discounts.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lv_Discounts.SelectedItems.Count > 0)
            {
                lv_Discounts.SelectedItems[0].Selected = false;
            }         
            currentMode = Mode.Add;
            btnSave.Visible = true;

            lblStatus.Text = "***Add New Discount***";

            txtTitle.Focus();
            txtTitle.Select();

            changeFieldStatus(true);
            clearFields();
            radio_Percent.Select();
            lv_Discounts.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (currentMode)
            {
                case Mode.Add:
                    addDiscount();
                    break;

                case Mode.Edit:
                    editDiscount();                   
                    break;

                case Mode.View:
                    btnSave.Visible = false;
                    break;

                default:
                    MessageBox.Show("Invalid mode.");
                    break;
            }
            
        }
        private Discounts populateDiscountObject(int flag)
        {
            discounts = new Discounts();
            discounts.Title = txtTitle.Text;
            discounts.Desc = txtDesc.Text;
            discounts.Type = radio_Percent.Checked ? DEFAULT_DISCOUNT_TYPE_PERCENT : DEFAULT_DISCOUNT_TYPE_FIXED;
            discounts.Less = Convert.ToDecimal(txtLess.Text);
            discounts.Flag = flag;
            
            return discounts;
        }
        private void txtLess_TextChanged(object sender, EventArgs e)
        {
             Validation.filterToDecimal(txtLess);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lv_Discounts.SelectedItems.Count > 0)
            {
                changeFieldStatus(true);
                currentMode = Mode.Edit;
                lblStatus.Text = "***Edit Discount***";

                btnSave.Visible = true;                
            }
            else
                MessageBox.Show("Please select a discount to edit.");         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                currentMode = Mode.Delete;
                lblStatus.Text = "***Deleting***";
                changeFieldStatus(false);
                btnSave.Visible = false;

                if (MessageBox.Show(String.Format("Are you sure you want to delete this discount? ({0})", txtTitle.Text), "Confirm Delete",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteDiscount();
                }
            }
            else
                MessageBox.Show("Please select a discount to delete.");
        }

        private void addDiscount()
        {
            if (Validation.isFilled(panel_Contents) && (radio_Fixed.Checked || radio_Percent.Checked))
            {
                populateDiscountObject(DEFAULT_FLAG);
                if (dbController.discountsMapper.addNewDiscount(discounts))
                {
                    MessageBanner banner = new MessageBanner("Successfully added a discount.");
                    banner.Opacity = 0.9;
                    banner.BackColor = System.Drawing.Color.ForestGreen;
                    banner.ForeColor = System.Drawing.Color.Black;
                    banner.Show();

                    clearFields();
                }
                else
                    MessageBox.Show("Failed to add new discount. Discount already exist.");
            }
            else
            {
                MessageBanner banner = new MessageBanner("Please fill up all the fields.");
                banner.Opacity = 0.9;
                banner.BackColor = System.Drawing.Color.Maroon;
                banner.ForeColor = System.Drawing.Color.WhiteSmoke;
                banner.Show();
            }
        }
        private void editDiscount()
        {
            if (Validation.isFilled(panel_Contents) && (radio_Fixed.Checked || radio_Percent.Checked))
            {
                populateDiscountObject(DEFAULT_FLAG);
                if (dbController.discountsMapper.updateDiscount(discounts))
                {
                    MessageBanner banner = new MessageBanner("Successfully updated discount.");
                    banner.Opacity = 0.9;
                    banner.BackColor = System.Drawing.Color.ForestGreen;
                    banner.ForeColor = System.Drawing.Color.Black;
                    banner.Show();

                    clearFields();
                }
                else
                    MessageBox.Show("Failed to update discount.");
            }
            else
            {
                MessageBanner banner = new MessageBanner("Please fill up all the fields.");
                banner.Opacity = 0.9;
                banner.BackColor = System.Drawing.Color.Maroon;
                banner.ForeColor = System.Drawing.Color.WhiteSmoke;
                banner.Show();
            }

        }
        private void deleteDiscount()
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                populateDiscountObject(DELETE_FLAG);
                if(dbController.discountsMapper.deleteDiscount(discounts))
                {
                    MessageBanner banner = new MessageBanner("Successfully deleted discount.");
                    banner.Opacity = 0.9;
                    banner.BackColor = System.Drawing.Color.ForestGreen;
                    banner.ForeColor = System.Drawing.Color.Black;
                    banner.Show();

                    clearFields();
                }
                else
                    MessageBox.Show("Failed to delete discount.");
            }
        }

        private void group_Type_Enter(object sender, EventArgs e)
        {

        }

        private void panel_Contents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
