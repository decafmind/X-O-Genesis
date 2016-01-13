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
    public partial class modalInspectProduct : Form
    {
        DatabaseController dbController;
        DataTable dtBasicInfo = new DataTable();
        InventoryView invView = new InventoryView();

        public string bcode;
        public modalInspectProduct(DatabaseController dbController)
        {
            InitializeComponent();
            this.dbController = dbController;
        }
        public modalInspectProduct()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modalInspectProduct_Load(object sender, EventArgs e)
        {
            displayBasicInfo();
        }
        //Lazy ass textbox population.
        private void displayBasicInfo()
        {
            dbController.getBasicProductInfoFromBarcode(dtBasicInfo, bcode);

            List<TextBox> txtBoxes = new List<TextBox>();
            foreach (Control c in panel_basicInfo.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    txtBoxes.Add(txt as TextBox);
                    txt.ReadOnly = true;
                }
            }
            foreach (DataRow dr in dtBasicInfo.Rows)
            {
                for (int i = 0; i < dtBasicInfo.Columns.Count; i++)
                {
                    txtBoxes[i].Text = dr[i].ToString();
                }
            }
            txtItemCode.Focus();
        }

        private void modalInspectProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                this.Close();
        }
    }
}
