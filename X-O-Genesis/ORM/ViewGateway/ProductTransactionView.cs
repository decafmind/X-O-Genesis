using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductTransactionView : DatabaseMapper
    {
        public ProductTransactionView(MySqlDB db)
            : base(db)
        {
            tableName = "product_transaction_view";
            fieldsname = new string[]{
                "transaction_id",
                "description",
                "unit_price",
                "qty_sold",
                "grp_price",
            };

            fieldsname_forselect = new string[]{
                "description AS Name",
                "unit_price AS 'Unit Price'",
                "SUM(qty_sold) AS 'Qty Sold'",
                "SUM(grp_price) AS 'Grp price'",
            };
        }
    }
}
