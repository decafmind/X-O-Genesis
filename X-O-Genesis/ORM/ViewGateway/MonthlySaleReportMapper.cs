using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class MonthlySaleReportMapper : DatabaseMapper
    {
        public MonthlySaleReportMapper(MySqlDB db)
            : base(db)
        {
            tableName = "monthly_sales_report";
            fieldsname = new string[] {
                "Month_index",
                "Month",
                "Sales",
            };
            fieldsname = new string[] {
                "CONCAT(Month, ', ', Year) AS Date",
                "Sales",
            };

        }
    }
}
