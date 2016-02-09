using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PetvetPOS_Inventory_System
{
    public class ProductInspectionMapper : DatabaseMapper
    {
        public ProductInspectionMapper(MySqlDB db)
            : base(db)
        {
            tableName = "product_inspection_view";
            id = "Item_Code";
            fieldsname = new string[] {
                "Item_Code",
                "Description",
                "Category",
                "Unit_Price",
                "Specification",
                "Warranty",
                "Replacement_Period",
                "Quantity_On_Hand",
            };
            fieldsname_forselect = new string[] {
                "Item_Code",
                "Description",
                "Category",
                "Unit_Price",
                "Specification",
                "Warranty",
                "Replacement_Period",
                "Quantity_On_Hand",
            };
        }
        public DataTable getStockMovement(DataTable dt, string productID)
        {
            selectQuery = String.Format("SELECT sold_items AS 'QTYSold', monthly AS 'Month' FROM stock_movement_view WHERE product_id = '{0}'", productID);
            return selectRows(dt, selectQuery);
        }
    }
}
