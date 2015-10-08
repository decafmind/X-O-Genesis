using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class WeeklySalesReport : DatabaseMapper
    {
        public WeeklySalesReport(MySqlDB db)
            : base(db)
        {
            tableName = "weekly_sales_report";
            fieldsname = new string[] {
                "Date",
                "Week",
                "Begin",
                "End",
                "Sales",
            };

            fieldsname_forselect = new string[] {
                "CONCAT(Begin, ' to ', End) AS Date",
                "Sales",
            };
        }
        
    }
}
