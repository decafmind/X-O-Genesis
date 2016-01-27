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

        public CompanyProf()
        {
        }

        public CompanyProf(Entity e)
        {
            try
            {
                Name = (string)e.getField("compname");
                Address = (string)e.getField("address");
                Contact = (string)e.getField("contactno");
                Email = (string)e.getField("email");
                Logo = (string)e.getField("logo_path");
            }
            catch (Exception)
            {
               // System.Windows.Forms.MessageBox.Show("This emloyee doesn't have a complete info");
            }
        }

     

    }

}
