using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    public partial class DiscountList : Form
    {

        DatabaseController dbController;
        List<Discounts> discountList = new List<Discounts>();
        DataTable discountTable;
        MasterController masterController;
        OrdersView ordersView;

        public Decimal[] discounts { get; set; } //For database recording (total discount)
        public Decimal[] accumulatedPercentageDiscount { get; set; } //For Net Price computation from List Price
        public Decimal[] accumulatedFixedDiscount { get; set; } //For Net Price computation from List Price

        private const int PERCENT_TYPE = 1;
        private const int FIXED_TYPE = 2;

        public DiscountList()
        {
            InitializeComponent();
        }
        public DiscountList(OrdersView ordersView)
        {
            this.ordersView = ordersView;
            InitializeComponent();
        }

        private void DiscountList_Load(object sender, EventArgs e)
        {
            LoadDiscounts();
        }
        void LoadDiscounts()
        {
            discountTable = new DataTable();
            dbController.discountsMapper.loadTable(discountTable);
            foreach (DataRow dr in discountTable.Rows)
            {
                Discounts discounts = new Discounts();
                discounts.Title = dr["title"].ToString();
                discounts.Type = Convert.ToInt32(dr["type"]);
                discounts.Less = Convert.ToDecimal(dr["less"]);

                discountList.Add(discounts);
            }

            int i = 0;
            int x = 10;
            int y = 10;
            CheckBox[] cbDiscounts = new CheckBox[discountList.Count];
            foreach (Discounts discounts in discountList)
            {
                cbDiscounts[i] = new CheckBox();
                cbDiscounts[i].Text = discounts.Title;
                cbDiscounts[i].Name = "cbDiscounts_" + i;
                panel_Discounts.Controls.Add(cbDiscounts[i]);
                cbDiscounts[i].SetBounds(x, y, panel_Discounts.Width, cbDiscounts[i].Height);
                y += 30;
                i++;    
            }
        }

        private Decimal[] getDiscounts()
        {
            List<string> selectedDiscounts = new List<string>();
            Decimal totalPercentage = 0;
            Decimal totalFixed = 0;

            discounts = new Decimal[2];
            
            foreach (Control c in panel_Discounts.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = c as CheckBox;
                    if (chk.Checked)
                    {
                        selectedDiscounts.Add(chk.Text);
                    }
                }
            }

            accumulatedPercentageDiscount = new Decimal[selectedDiscounts.Count];
            accumulatedFixedDiscount = new Decimal[selectedDiscounts.Count];

            int iterator_a = 0;
            int iterator_b = 0;
            discountTable = new DataTable();
            dbController.discountsMapper.loadTable(discountTable);

            foreach (DataRow dr in discountTable.Rows)
            {
                if(selectedDiscounts.Contains(dr["title"].ToString()))
                {
                    if (Convert.ToInt32(dr["type"]).Equals(FIXED_TYPE))
                    {
                        totalFixed += Convert.ToDecimal(dr["less"].ToString());
                        accumulatedFixedDiscount[iterator_a] = Convert.ToDecimal(dr["less"]);
                        iterator_a++;
                    }
                    else if (Convert.ToInt32(dr["type"]).Equals(PERCENT_TYPE))
                    {
                        totalPercentage += Convert.ToDecimal(dr["less"].ToString());
                        accumulatedPercentageDiscount[iterator_b] = Convert.ToDecimal(dr["less"]);
                        iterator_b++;
                    }
                }
            }

            discounts[0] = totalPercentage;
            discounts[1] = totalFixed;

            return discounts;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getDiscounts();
            ordersView.productTransaction.DiscPercent = discounts[0];
            ordersView.productTransaction.DiscFixed = discounts[1];
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
