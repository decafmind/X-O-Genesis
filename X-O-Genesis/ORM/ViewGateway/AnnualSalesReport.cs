using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class AnnualSalesReport : DatabaseMapper
    {
        public AnnualSalesReport(MySqlDB db)
            : base(db)
        {
            tableName = "annual_sales_report";
            fieldsname = new string[]{
                "Year",
                "Sales",
            };
        }
    }
}
