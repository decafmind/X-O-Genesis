using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Inventory: IEntity
    {
        public int InventoryId { get; set; }
        public string Barcode { get; set; }
        public DateTime StockinDateTime { get; set; }
        public int QtyReceived { get; set; }
        public string Supplier { get; set; }
        public int QtyOnHand { get; set; }

        public Inventory()
        {

        }

        public Inventory(Entity entity)
        {
            try
            {
                 Barcode = (string)entity.getField("product_id");
                 StockinDateTime = (DateTime)entity.getField("stockin_datetime");
                 QtyReceived = (int)entity.getField("qty_received");
                 Supplier = (string)entity.getField("supplier");
                 QtyOnHand = (int)entity.getField("qty_onhand");
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }

    }
}
