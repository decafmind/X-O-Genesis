using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Employee: IEntity
    {
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string Lastname { get; set; }

        public string MobileNo { get; set; }
        public string TelNo { get; set; }
        public string EmailAddress { get; set; }

        public DateTime RegisteredDate { get; set; }
        public string User_id { get; private set; }
        public int Employee_Id { get; set; }

        public string Address { get; set; }
        public string ImagePath { get; set; }
        public UserLevel Position { get; set; }

        public Employee()
        {

        }

        public Employee(User user)
        {
            User_id = user.UserId;
            Position = user.getUserLevel();
            user.Dispose();
        }

        public Employee(Entity e)
        {
            try
            {
                User_id = (string)e.getField("user_id");
                Firstname = (string)e.getField("firstname");
                MiddleName = (string)e.getField("middlename");

                Lastname = (string)e.getField("lastname");
                MobileNo = (string)e.getField("mobile_no");
                TelNo = (string)e.getField("telephone_no");

                EmailAddress = (string)e.getField("email_address");
                ImagePath = (string)e.getField("image_path");
                Address = (string)e.getField("address");

                RegisteredDate = (DateTime)e.getField("registered_date");
            }
            catch (Exception)
            {
               // System.Windows.Forms.MessageBox.Show("This emloyee doesn't have a complete info");
            }
        }

        public override string ToString()
        {
            return Employee_Id.ToString();
        }


    }
}
