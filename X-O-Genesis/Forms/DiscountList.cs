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
        DiscountList dcList = new DiscountList();

        public DiscountList()
        {
            InitializeComponent();
        }
        public DiscountList(DatabaseController dbController)
        {
            this.dbController = dbController;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

    }
}
