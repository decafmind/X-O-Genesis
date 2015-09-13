using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class DailySalesReportMapper:DatabaseMapper
    {
        public DailySalesReportMapper(MySqlDB db)
            : base(db)
        {
            tableName = "daily_sales_report";
            fieldsname = new string[] {
                "transaction_date",
                "Sales",
            };

            fieldsname_forselect = new string[] {
                "transaction_date AS 'Date'",
                "Sales",
            };
        }
    }
}
