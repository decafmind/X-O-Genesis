using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PetvetPOS_Inventory_System
{
    public class CustomerInfoView : DatabaseMapper
    {
        public CustomerInfoView(MySqlDB db)
            : base(db)
        {
            tableName = "customer_view";
            fieldsname = new string[]{
                "cname",
                "mobile_number",
            };

            fieldsname_forselect = new string[]{
                "cname AS Name",
                "mobile_number as ContactNo",
            };
        }
    }
}
