using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PetvetPOS_Inventory_System
{
    public class CustomerInformationMapper:DatabaseMapper
    {
        //public event EventHandler CustomerAdded;
        //MasterController masterController;

        public CustomerInformationMapper(MySqlDB db):base(db)
        {
            tableName = "customer_tbl";
            id = "id";
            fieldsname = new string[] {
                "firstname", 
                "middlename", 
                "lastname", 
                "mobile_number", 
                "telephone_number", 
                "email_address",
                "address" };

            fieldsname_forselect = new string[] {
                "firstname AS Firstname",
                "middlename AS Middlename",
                "lastname AS Lastname",
                "mobile_number AS 'Mobile Number'" };
        }


        //private void OnCustomerAdded(EventArgs e)
        //{
        //    EventHandler onCustomerAdded = CustomerAdded;
        //    if (onCustomerAdded != null)
        //        onCustomerAdded(this, e);
        //}

        public void insertCustomerInformation(CustomerInformation customer)
        {
            if (create(insertValues(customer.Firstname, customer.Middlename, customer.Lastname,
                customer.Mobile_number, customer.Telephone_number, customer.Email_address, customer.Address)))
            {
                // OnCustomerAdded(new EventArgs());
                MessageBanner banner = new MessageBanner("Successful adding information.", 2000);
                banner.Show();
            }

        }

    
    }



}
