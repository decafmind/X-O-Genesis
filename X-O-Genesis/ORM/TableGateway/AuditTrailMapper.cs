using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class AuditTrailMapper : DatabaseMapper
    {
        public AuditTrailMapper(MySqlDB db)
            : base(db)
        {
            tableName = "audit_trail_tbl";
            fieldsname = new string[]{
                "employee_id",
                "activity",
                "date",
                "time",
            };
        }

        public bool insertAuditTrail(Employee employee, string action, DateTime date)
        {   
            return create(
                insertValues(employee.User_id, action, MyExtension.MySqlToCSharp.convertDate(date), MyExtension.MySqlToCSharp.convertTime(date))
                );
        }
    }
}
