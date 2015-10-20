using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductInventory : DatabaseMapper
    {
        public ProductInventory(MySqlDB db)
            : base(db)
        {
            // This mapper operated on view
           
            tableName = "inventory_view";
            fieldsname = new string[] {
                "Name",
                "Barcode",
                "Unit_price",
                "Qty_on_Hand",
                "Qty_Received",
                "Stock_since",
            };

            fieldsname_forselect = new string[]{
                "Name",
                "Qty_on_Hand AS 'Qty on Hand'",
                "Qty_Received AS 'Qty received'",
                "Stock_since AS 'Stock since'",
            };
        }

        public DataTable loadInventoryTable(DataTable dt)
        {
            return loadTable(dt);
        }

        public DataTable getCriticalLevelProducts(DataTable dt)
        {
            selectQuery = "SELECT Name, Qty_On_Hand AS 'Stock', Qty_Received AS 'Qty on Received' FROM inventory_view WHERE Qty_On_Hand <= (Qty_Received * .20)";
            return selectRows(dt, selectQuery);
        }

        public void checkProductCriticalLevel(Product product, MasterController masterController)
        {
            string condition = string.Format("Name = '{0}'", product.Description);
            decimal qty_received = (decimal)readScalar("Qty_Received", condition);
            decimal qty_onhand = (decimal)readScalar("Qty_On_Hand", condition);

            if (qty_onhand <= (qty_received * .10M))
            {
                CriticalNotif notif = new CriticalNotif(product, (int)qty_onhand);
                notif.Location = new Point(masterController.getFrmMain.Height - notif.Height,
                                            masterController.getFrmMain.Width - notif.Width
                                            );
                notif.Show();
            }
        }

        public decimal getStockQuantity(Product product)
        {
            string condition = string.Format("Name = '{0}'", product.Description);
            decimal qty_onhand = (decimal)readScalar("Qty_On_Hand", condition);
            return qty_onhand;
        }
    }
}
