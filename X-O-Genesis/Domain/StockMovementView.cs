using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class StockMovementView
    {
        public int SoldItems { get; set; }
        public string Product_ID { get; set; }
        public int Monthly { get; set; }
        public int Yearly { get; set; }

        public StockMovementView()
        {

        }
        public StockMovementView(Entity entity)
        {
            SoldItems = (int)entity.getField("sold_items");
            Product_ID = (string)entity.getField("product_id");
            Monthly = (int)entity.getField("monthly");
            Yearly = (int)entity.getField("yearly");
        }
    }
}
