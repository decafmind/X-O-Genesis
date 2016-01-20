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
    // Baseclass for Audit trail & Login trail
    public partial class TrailView : MyUserControl
    {
        List<User> users = new List<User>();
        List<Trail> trails = new List<Trail>();
        DataTable dt = new DataTable("Trail");
     
        public TrailView()
        {
            InitializeComponent();
        }

        void initTable()
        {
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("LoginDateTime", typeof(DateTime));
            dt.Columns.Add("LogoutDateTime", typeof(DateTime));
        }

        public void setTrailView(List<LoginTrail> trails)
        {
            foreach (LoginTrail loginTrail in trails)
            {
                var row = dt.NewRow();
                row["Username"] = loginTrail.Username;
                row["LoginDateTime"] = loginTrail.LoginDateTime;
                row["LogoutDateTime"] = loginTrail.LogoutDateTime;
                dt.Rows.Add(row);
            }

            trailGrid.DataSource = dt;
        }

        public List<User> Users 
        { 
            get { return users; } 
            set {
                users = value;
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrailView_Load(object sender, EventArgs e)
        {

        }
    }
}
