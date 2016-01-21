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
                "Description",
                "Barcode",
                "Unit_price",
                "Qty_on_Hand",
                "Qty_Received",
                "Stock_since",
                "Supplier",
                "Category",
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

        public ProductInventoryDomain getProductInventoryThroughBarcode(string barcode)
        {
            Product product = new Product(getEntityWhere(string.Format("Barcode = '{0}'", barcode)),true);
            Inventory inventory = new Inventory(getEntityWhere(string.Format("Barcode = '{0}'", barcode)),true);
            return new ProductInventoryDomain(product, inventory);
        }

        public void checkProductCriticalLevel(Product product, MasterController masterController)
        {
            try
            {
                string condition = string.Format("Name = '{0}'", product.Description);
                decimal qty_received = (decimal)readScalar("Qty_Received", condition);
                decimal qty_onhand = (decimal)readScalar("Qty_On_Hand", condition);

                if (qty_onhand <= (qty_received * .10M))
                {
                    masterController.displayCriticalNotif(product, (int)qty_onhand);
                }
            }
            catch (NullReferenceException)
            {

            }
            
        }

        public decimal getStockQuantity(Product product)
        {
            string condition = string.Format("Name = '{0}'", product.Name);
            decimal qty_onhand = (decimal)readScalar("Qty_On_Hand", condition);
            return qty_onhand;
        }
    }
}
