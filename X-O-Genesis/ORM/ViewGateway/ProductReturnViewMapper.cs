using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductReturnViewMapper : DatabaseMapper
    {
        public ProductReturnViewMapper(MySqlDB db)
            : base(db)
        {
            tableName = "product_return_view";
            fieldsname = new string[]{
                "transaction_no",
                "product",
                "qty_returned",
                "date_returned",
                "supplier",
                "reason",
            };

            fieldsname_forselect = new string[]{
                "transaction_no as 'Transaction no.'",
                "product AS 'Product'",
                "qty_returned AS 'Qty'",
                "date_returned AS 'Date returned'",
                "supplier AS 'Supplier'",
                "reason AS 'Reason'",
            };
        }
    }
}
