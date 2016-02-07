using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PetvetPOS_Inventory_System
{
    public class CompanyProf: IEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }

        public void Save()
        {
            Properties.Settings.Default.CompanyName = Name;
            Properties.Settings.Default.CompanyAddress = Address;
            Properties.Settings.Default.CompanyContact = Contact;
            Properties.Settings.Default.CompanyEmail = Email;
            Properties.Settings.Default.CompanyLogoImagPath = Logo;
            Properties.Settings.Default.Save();
        }
     

    }

}
