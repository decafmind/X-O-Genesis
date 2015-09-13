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
                "description",
                "Qty_returned",
                "Price_refunded",
            };
            fieldsname_forselect = new string[]{
                "Description AS Name",
                "Qty_returned AS 'Qty returned'",
                "Price_refunded AS 'Price refunded'",
            };
        }
    }
}
