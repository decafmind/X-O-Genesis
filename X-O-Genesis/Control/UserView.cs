using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Randy.GraphicsLibrary;
using System.IO;
using MyExtension;

namespace PetvetPOS_Inventory_System
{
    public partial class UserView : MyUserControl
    {
        DatabaseController dbController;

        public UserView()
        {
            InitializeComponent();
        }

        public UserView(Panel panel, MasterController masterController)
            : base(masterController, panel, true)
        {
            InitializeComponent();
            dbController = masterController.DataBaseController;
        }

        public void showUser(Employee employee)
        {
            lblName.Text = employee.Firstname + " " + employee.MiddleName + " " + employee.Lastname;
            lblPosition.Text = employee.Position.ToString();
            lblMobileno.Text = employee.MobileNo.ToString();

            lblTelno.Text = employee.TelNo.ToString();
            lblEmailadd.Text = employee.EmailAddress.ToString();
            lblRegistrationdate.Text = employee.RegisteredDate.ToLongDateString();

            lblUsername.Text = employee.User_id;
            lblAddress.Text = employee.Address;
            if (File.Exists(@employee.ImagePath))
                userImage.Image = Renderer.resizeImage(Image.FromFile(@employee.ImagePath) as Bitmap, userImage.Width, userImage.Height) as Image;
            else
                userImage.Image = Renderer.resizeImage(Properties.Resources.userBlack, userImage.Width, userImage.Height) as Image;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void filterNames(object sender, EventArgs e)
        {
            Validation.filterToNames(sender as TextBox);
        }
        private void filterContacts(object sender, EventArgs e)
        {
            Validation.filterToContactNo(sender as TextBox);
        }
        private void filterEmail(object sender, EventArgs e)
        {
            Validation.filterToEmail(sender as TextBox);
        }
        private void filterParagraph(object sender, EventArgs e)
        {
            Validation.filterToParagraph(sender as TextBox);
        }
        private void filterAlphabet(object sender, EventArgs e)
        {
            Validation.filterToAplha(sender as TextBox);
        }
        private void filterNumeric(object sender, EventArgs e)
        {
            Validation.filterToNumeric(sender as TextBox);
        }
        private void filterAplhaNumeric(object sender, EventArgs e)
        {
            Validation.filterToAlphaNumeric(sender as TextBox);
        }
    }
}
