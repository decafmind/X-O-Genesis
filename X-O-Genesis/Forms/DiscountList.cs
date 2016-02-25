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
    public partial class DiscountsAdv : Form
    {

        DatabaseController dbController;
        
        DataTable discountTable;
        OrdersView ordersView;
      
        public Decimal totalDiscountedAmount;
        public List<string> selectedDiscounts;
        public List<Discounts> discountList = new List<Discounts>();
        public List<Discounts> availedDiscounts = new List<Discounts>();
        public Decimal[] discounts { get; set; } //For database recording (total discount)
        public Decimal[] accumulatedPercentageDiscount { get; set; } //For Net Price computation from List Price
        public Decimal[] accumulatedFixedDiscount { get; set; } //For Net Price computation from List Price

        List<decimal> percentage;
        List<decimal> fixedPrice;
           
        const int PERCENT_TYPE = 1;
        const int FIXED_TYPE = 2;

        decimal totalAmount = 0;

        public DiscountsAdv()
        {
            InitializeComponent();
        }

        public DiscountsAdv(OrdersView ordersView, DatabaseController dbController)
        {
            this.ordersView = ordersView;
            this.dbController = ordersView.dbController;
            InitializeComponent();
        }

        private void DiscountList_Load(object sender, EventArgs e)
        {
            LoadDiscounts();
            btnAdd.Enabled = false;
        }

        void LoadDiscounts()
        {
            lblDiscountedTotal.Text = "0";
          
            discountTable = new DataTable();

            //Fetch discounts from db
            dbController.discountsMapper.loadTable(discountTable);
            foreach (DataRow dr in discountTable.Rows)
            {
                Discounts discounts = new Discounts();
                discounts.Title = dr["title"].ToString();
                discounts.Type = Convert.ToInt32(dr["type"]);
                discounts.Less = Convert.ToDecimal(dr["less"]);

                discountList.Add(discounts);
            }

            //Display discounts for selection
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

        private void getDiscounts()
        {
            selectedDiscounts = new List<string>();
            Discounts d;

            Decimal totalPercentage = 0;
            Decimal totalFixed = 0;
            
            discounts = new Decimal[2];
            
            //Get all selected discounts
            foreach (Control c in panel_Discounts.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox ch = c as CheckBox;                  
                    if (ch.Checked)
                    {
                        selectedDiscounts.Add(ch.Text);
                    }
                }
            }

            accumulatedPercentageDiscount = new Decimal[selectedDiscounts.Count];
            accumulatedFixedDiscount = new Decimal[selectedDiscounts.Count];

            int iterator_a = 0;
            int iterator_b = 0;
            discountTable = new DataTable();
            dbController.discountsMapper.loadTable(discountTable);

            //Add up all the discounts selected for recording           
            foreach (DataRow dr in discountTable.Rows)
            {
                if(selectedDiscounts.Contains(dr["title"].ToString()))
                {
                    if (Convert.ToInt32(dr["type"]).Equals(FIXED_TYPE))
                    {
                        totalFixed += Convert.ToDecimal(dr["less"].ToString());
                        accumulatedFixedDiscount[iterator_a] = Convert.ToDecimal(dr["less"]);

                        d = new Discounts();
                        d.Type = FIXED_TYPE;
                        d.Title = dr["title"].ToString();
                        d.Less = Convert.ToInt32(dr["less"]);

                        availedDiscounts.Add(d);

                        iterator_a++;
                    }
                    else if (Convert.ToInt32(dr["type"]).Equals(PERCENT_TYPE))
                    {
                        totalPercentage += Convert.ToDecimal(dr["less"].ToString());
                        accumulatedPercentageDiscount[iterator_b] = Convert.ToDecimal(dr["less"]);

                        d = new Discounts();
                        d.Type = PERCENT_TYPE;
                        d.Title = dr["title"].ToString();
                        d.Less = Convert.ToInt32(dr["less"]);

                        availedDiscounts.Add(d);

                        iterator_b++;
                    }
                }
            }

            //These are the total discounts accumulated to be recorded
            discounts[0] = totalPercentage;
            discounts[1] = totalFixed;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getDiscounts();
            foreach (ProductInvoice items in ordersView.carts)
            {
                items.DiscPercent = discounts[0];
                items.DiscFixed = discounts[1];
                ordersView.withDiscounts = true;
            }        
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void showDiscountedTotal()
        {
            totalAmount = ordersView.totalAmount;

            percentage = new List<decimal>();
            fixedPrice = new List<decimal>();

            discountTable = new DataTable();
            dbController.discountsMapper.loadTable(discountTable);

            bool hasDiscount = false;

            //Process values
            foreach (Control c in panel_Discounts.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = c as CheckBox;
                    if (chk.Checked)
                    {
                        hasDiscount = discountTable.AsEnumerable()
                            .Any(row => chk.Text == row.Field<String>("title"));

                        if (hasDiscount)
                        {
                            var type = from d in discountTable.AsEnumerable()
                                       where d.Field<string>("title") == chk.Text
                                       select d.Field<int>("type");
                            if (type.Contains(1))
                            {
                                var disc = (from d in discountTable.AsEnumerable()
                                           where d.Field<string>("title") == chk.Text
                                           select d.Field<decimal>("less")).FirstOrDefault();

                                percentage.Add(disc);
                            }
                            else if (type.Contains(2))
                            {
                                var disc = (from d in discountTable.AsEnumerable()
                                           where d.Field<string>("title") == chk.Text
                                           select d.Field<decimal>("less")).FirstOrDefault();

                                fixedPrice.Add(disc);
                            }
                           
                        }
                    }
                }
            }
          
            foreach (Decimal percentDisc in percentage)
            {
                totalAmount = totalAmount * (1 - percentDisc / 100);
            }

            foreach (Decimal percentFixed in fixedPrice)
            {
                totalAmount = totalAmount - percentFixed;
            }

            totalDiscountedAmount = totalAmount;
            lblDiscountedTotal.Text = totalDiscountedAmount.ToString("N");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showDiscountedTotal();
            btnAdd.Enabled = true;
        }
    }
}
