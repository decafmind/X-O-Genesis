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
                "SerialCode",
                "Unit",
                "UnitCost",
                "MaintainingStocks",
                "Warranty",
                "Replacement",
            };

            fieldsname_forselect = new string[]{
                "Name",
                "Description",
                "Qty_on_Hand AS 'Qty on Hand'",
                "MaintainingStocks AS 'Maintaining Stocks'",
                "Category",
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

        public bool checkIfProductIsCritical(Product product)
        {
            string condition = string.Format("barcode = '{0}'", product.Barcode);
            int maintaining_stocks = (int)readScalar("MaintainingStocks", condition);
            int qty_onhand = (int)(decimal)readScalar("Qty_on_Hand", condition);

            if (qty_onhand <= maintaining_stocks)
                return true;
            else
                return false;
        }

        public bool checkProductCriticalLevel(Product product, MasterController masterController)
        {
            try
            {
                string condition = string.Format("barcode = '{0}'", product.Barcode);
                int maintaining_stocks = (int)readScalar("MaintainingStocks", condition);
                int qty_onhand = (int)(decimal)readScalar("Qty_on_Hand", condition);

                if (qty_onhand <= maintaining_stocks)
                {
                    masterController.displayCriticalNotif(product, (int)qty_onhand);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {

            }
            return false;
        }

        public decimal getStockQuantity(Product product)
        {
            string condition = string.Format("barcode = '{0}'", product.Barcode);
            decimal qty_onhand = (decimal)readScalar("Qty_On_Hand", condition);
            return qty_onhand;
        }

        public decimal getMaintainingStocks(Product product)
        {
            decimal maintaining_stocks;
            try{
                string condition = string.Format("id = '{0}'", product.Barcode);
                maintaining_stocks = (decimal)readScalar("MaintainingStocks", condition);
            }catch (Exception e){
                ErrorLog.Log(e);
                maintaining_stocks = 0;
            }
            return maintaining_stocks;
        }
    }
}
