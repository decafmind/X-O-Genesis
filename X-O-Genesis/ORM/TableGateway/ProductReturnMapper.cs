using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductReturnMapper : DatabaseMapper
    {
        public ProductReturnMapper(MySqlDB mysqlDB)
            : base(mysqlDB)
        {
            tableName = "product_return_tbl";
            fieldsname = new string[]
            {
                "product_invoice_id",
                "qty_returned",
                "date_returned",
                "reason",
                "product_id",
            };
        }

        public bool insertProductReturn(ProductReturned productReturned){
            return create(
                insertValues(productReturned.productInvoiceId, productReturned.qtyReturned, MyExtension.MySqlToCSharp.convertDate(productReturned.date), productReturned.reason, productReturned.product_id)
                );
        }
    }
}
