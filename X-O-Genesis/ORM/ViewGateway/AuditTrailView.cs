using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class AuditTrailView : DatabaseMapper
    {
        public AuditTrailView(MySqlDB db) : base(db)
        {
            tableName = "audit_trail_view";
            fieldsname = new string[]{
                "date_time",
                "activity",
                "user_id",
            };
            fieldsname_forselect = new string[]{
                "activity AS 'Activity'",
                "date_time AS 'Date & Time'",
            };
        }
    }
}
