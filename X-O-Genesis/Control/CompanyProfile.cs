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
using Randy.GraphicsLibrary;
using System.IO;

namespace PetvetPOS_Inventory_System
{
    public partial class CompanyProfile : MyUserControl, IContentPage
    {
        CompanyProf companyProfile;
        DataTable companyProfileTable;
        Bitmap companyLogo;
        bool hasPictureChanged;

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

        private void saveImage()
        {
            try
            {
                string destFolder = Constants.rootFolder +  @"Images\";

                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);

                Random random = new Random();
                string imagePath = destFolder + random.Next(1000) + DateTime.Now.Millisecond.ToString() + ".jpg";
                lblPath.Text = imagePath;

                using (Bitmap image = companyLogo as Bitmap)
                {
                    image.Save(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in saving image");
            }
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
                    VatRegTin = txtVATRegTin.Text,
                    Tax = Convert.ToDouble(txtTax.Text) / 100,
                };

                if (hasPictureChanged)
                    saveImage();

                if (dbController.updateCompanyProfile(companyProfile))
                {
                    SettingArgs s = new SettingArgs(Settings.COMPANY_PROFILE);
                    masterController.OnSettingsChanged(s);

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
            loadCompanyProfile();
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
                txtVATRegTin.Text = dr["vat_reg_tin"].ToString();
                txtTax.Text = (Convert.ToDouble(dr["tax"]) * 100).ToString();
            }

            if (File.Exists(lblPath.Text))
               pbCompanyLogo.Image = Renderer.resizeImage(Image.FromFile(lblPath.Text) as Bitmap, pbCompanyLogo.Width, pbCompanyLogo.Height) as Image;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*jpeg;*.png";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = @fileDialog.FileName;
                companyLogo = Image.FromFile(filename) as Bitmap;
                pbCompanyLogo.Image = Renderer.resizeImage(companyLogo, pbCompanyLogo.Width, pbCompanyLogo.Height);
                lblPath.Text = filename;

                hasPictureChanged = true;
            }
        }
    }
}
