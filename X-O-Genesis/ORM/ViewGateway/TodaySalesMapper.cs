using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class TodaySalesMapper: DatabaseMapper
    {
        public TodaySalesMapper(MySqlDB db)
            : base(db)
        {
            tableName = "sales_today_view";
            fieldsname = new string[] {
                "Date",
                "Total_Sales",
            };
        }

        public decimal getSales(){
            decimal foo;
            try
            {
                if (decimal.TryParse(readScalar("Total_Sales", "1=1").ToString(), out foo))
                    return foo;
                else
                    return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
