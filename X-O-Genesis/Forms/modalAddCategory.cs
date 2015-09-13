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
    public partial class modalAddCategory : Form
    {
        DatabaseController dbController;
        ProductPaneScroll scroll;
        List<string> categoryList;

        public modalAddCategory(DatabaseController dbController, ProductPaneScroll scroll)
        {
            InitializeComponent();
            this.dbController = dbController;
            this.scroll = scroll;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modalAddCategory_Load(object sender, EventArgs e)
        {
            txtCategory.Focus();
            categoryList = dbController.getListOfCategory();
        }

        void addNewCategory(string category)
        {
            if (dbController.createCategory(category))
            {
                scroll.loadCategoryList();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(categoryList.Contains(txtCategory.Text)){
                MessageBox.Show("Category already exists", "Message");
            } else{
                addNewCategory(txtCategory.Text);
                scroll.selectNewlyAddedCategory(txtCategory.Text);
                Close();
            }
        }
    }
}
