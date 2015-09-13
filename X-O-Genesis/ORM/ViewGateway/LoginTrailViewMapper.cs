
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class LoginTrailViewMapper : DatabaseMapper
    {
        public LoginTrailViewMapper(MySqlDB db)
            : base(db)
        {
            tableName = "login_trail_view";
            fieldsname = new string[]{
                "employee_name",
                "datetime_in",
                "datetime_out",
            };

            fieldsname_forselect = new string[]{
                "employee_name AS 'Employee name'",
                "datetime_in AS 'Login date & time'",
                "datetime_out AS 'Logout date & time'",
            };
        }
    }
}
