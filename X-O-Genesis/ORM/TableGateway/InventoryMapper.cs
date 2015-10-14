using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class InventoryMapper : DatabaseMapper
    {
        public InventoryMapper(MySqlDB mySqlDb)
            : base(mySqlDb)
        {
            tableName = "inventory_tbl";
            id = "id";
            fieldsname = new string[] {
                "product_id",
                "stockin_datetime",
                "qty_received",
                "qty_onhand",
            };

            fieldsname_forselect = new string[]{
                "product_id AS Barcode",
                "stockin_datetime AS 'Stock since'",
                "qty_received AS 'Qty on Received'",
                "qty_onhand AS 'Qty on Hand'",
            };
        }

        public string createInventory(Inventory inventory)
        {
            return insertValues(
                inventory.Barcode, "NOW()", inventory.QtyReceived,
                inventory.QtyOnHand);
        }

        public bool pullInventory(Inventory inventory)
        {
            return create(
                insertValues(inventory.Barcode, "null", "null",
                inventory.QtyOnHand));
        }

        public DataTable loadInventoryTable(DataTable dt)
        {
            return loadTable(dt);
        }

        public bool insertInventory(Inventory inventory)
        {
            return create(createInventory(inventory));
        }
        public bool updateInventory(int qty, string barcode)
        {
            string qty_onhand = String.Format(" qty_onhand = {0}", qty);
            string condition = String.Format(" product_id = '{0}'", barcode);
            updateSet(condition, qty_onhand);
            return update(updateQuery);
        }
  
    }
}
