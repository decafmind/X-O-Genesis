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
    public partial class CompanyProfile : MyUserControl, IContentPage
    {
        DatabaseController dbController;
        CompanyProf companyProfile;
        DataTable companyProfileTable;

        public CompanyProfile()
        {
            InitializeComponent();
        }

        public CompanyProfile(MasterController masterController)
            : base(masterController)
        {
            InitializeComponent();
            this.dbController = masterController.DataBaseController;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateCompanyProfile();
        }

        void updateCompanyProfile()
        {
            MessageBanner banner;
            if (MyExtension.Validation.isFilled(panel1))
            {
                companyProfile = new CompanyProf()
                {
                    Name = txtCompName.Text,
                    Address = txtAdd.Text,
                    Contact = txtCont.Text,
                    Email = txtEmail.Text,
                    Logo = lblPath.Text,
                };

                if (dbController.updateCompanyProfile(companyProfile))
                {
                    banner = new MessageBanner("Successful updating company profile.", 2000);
                    banner.Opacity = 1;
                    banner.BackColor = System.Drawing.Color.Green;
                    banner.ForeColor = System.Drawing.Color.White;
                    banner.Show();
                }
                else
                {
                    banner = new MessageBanner("Failed to update company profile.", 2000);
                    banner.Opacity = 1;
                    banner.BackColor = System.Drawing.Color.DarkRed;
                    banner.ForeColor = System.Drawing.Color.White;
                    banner.Show();
                }
            }
            else
            {
                banner = new MessageBanner("Please fill up all the required fields", 2000);
                banner.Opacity = 1;
                banner.BackColor = System.Drawing.Color.DarkRed;
                banner.ForeColor = System.Drawing.Color.White;
                banner.Show();
            }
        }

        void loadCompanyProfile()
        {
            companyProfileTable = new DataTable();
            dbController.loadCompanyProfile(companyProfileTable);

            foreach (DataRow dr in companyProfileTable.Rows)
            {
                txtCompName.Text = dr["compname"].ToString();
                txtAdd.Text = dr["address"].ToString();
                txtCont.Text = dr["contactno"].ToString();
                txtEmail.Text = dr["email"].ToString();
                lblPath.Text = dr["logo_path"].ToString();
            }
        }

        public void initializePage()
        {
           
        }

        public void finalizePage()
        {
           
        }

        public Menu accessMenuName
        {
            get 
            {
                return Menu.Company_Profile;
            }
        }

        public Bitmap accessImage
        {
            get 
            {
                return Properties.Resources.homeIcon;
            }
        }

        private void CompanyProfile_Load(object sender, EventArgs e)
        {
            loadCompanyProfile();
        }

        private void txtCont_TextChanged(object sender, EventArgs e)
        {     
            Validation.filterToContactNo(sender as TextBox);
        }
    }
}
