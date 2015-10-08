using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class LoginTrailMapper: DatabaseMapper
    {
        public LoginTrailMapper(MySqlDB db)
            : base(db)
        {
            tableName = "login_trail_tbl";
            id = "id";
            fieldsname = new string[]{
                "user_id",
                "datetime_in",
                "datetime_out",
            };
            fieldsname_forselect = new string[]{
                "user_id AS User",
                "datetime_in AS 'Login DateTime'",
                "datetime_out AS 'Logout DateTime'",
            };
        }

        public DataTable getLoginTrailTable(DataTable dataTable)
        {
            return loadTable(dataTable);
        }

        public void insertTimeIn(Employee employee)
        {
            insertQuery = String.Format("INSERT INTO login_trail_tbl(user_id) VALUES('{0}')",employee.User_id);
            create(insertQuery);
        }

        public void insertTimeout(Employee employee)
        {
            int last_id = int.Parse(readScalar("id", "1 = 1 ORDER BY datetime_in DESC").ToString());
            string condition = String.Format("user_id = '{0}' AND id = {1}", employee.User_id, last_id);
            string set = "datetime_out = NOW()";
            update(updateSet(condition, set));
        }

        private class loginTrailViewMapper: LoginTrailMapper
        {
            public loginTrailViewMapper(MySqlDB db)
                : base(db)
            {
                tableName = "login_trail_view";
                fieldsname = new string[]{
                    "user_id",
                    "employee_name",
                    "datetime_in",
                    "datetime_out",
                };
            }

            public DataTable getLoginTrailViewTable(DataTable dt)
            {
                return loadTable(dt);
            }
        }
    }
}
