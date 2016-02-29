using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class StockMovementViewMapper : DatabaseMapper
    {
        public StockMovementViewMapper(MySqlDB db)
            : base(db)
        {
            id = "id";
            tableName = "stock_movement_tbl";
            fieldsname = new string[]{
                "sold_items",
                "product_id",
                "monthly",
                "yearly",
            };
        }

        public bool createStockMovementView(StockMovementView stockMovementView)
        {
            return create(insertValues(stockMovementView.SoldItems, stockMovementView.Product_ID,
                stockMovementView.Monthly));
        }
    }
}
