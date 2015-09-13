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
                "description",
                "unit_price",
                "SUM(qty_sold) AS 'Qty sold'",
                "SUM(grp_price) AS 'Grp price'",
            };
        }
    }
}
