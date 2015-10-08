using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class CustomerInformation
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Mobile_number { get; set; }
        public string Telephone_number { get; set; }
        public string Email_address { get; set; }
        public string Address { get; set; }

        public CustomerInformation()
        {

        }

        public CustomerInformation(Entity entity)
        {
            try
            {
                //id = (int)entity.getField("id");
                Firstname = (string)entity.getField("firstname");
                Middlename = (string)entity.getField("middlename");
                Lastname = (string)entity.getField("lastname");
                Mobile_number = (string)entity.getField("mobile_number");
                Telephone_number = (string)entity.getField("telephone_number");
                Email_address = (string)entity.getField("email_address");
                Address = (string)entity.getField("address");
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }
    }
}
