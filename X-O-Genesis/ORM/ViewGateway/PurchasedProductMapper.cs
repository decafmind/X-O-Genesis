using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class PurchasedProductMapper: DatabaseMapper
    {
        public PurchasedProductMapper(MySqlDB db):base(db)
        {
            // This mapper operates on another views
            tableName = "purchased_product_view";
            fieldsname = new string[] {
                "Name",
                "Barcode",
                "quantity",
                "unit_price",
                "Sales",
                "category",
                "Company",
            };

            fieldsname_forselect = new string[] {
                "Name",
                "unit_price AS 'Price (Peso)'",
                "quantity AS 'Qty Sold'",
                "Sales AS' Subtotal (Peso)'",
            };
        }

        public DataTable getBestSellers(DataTable dt)
        {
            selectQuery = "SELECT Name, Item_Sold AS 'Item Sold', Percent_Share AS '%' FROM bestsellers WHERE Item_Sold > 0";
            return selectRows(dt, selectQuery);
        }
    }
}
