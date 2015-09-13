using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class TodaySales: IEntity
    {
        public decimal Sales { get; set; }
        public DateTime Today { get; set; }

        public TodaySales(decimal sales)
        {
            this.Sales = sales;
            Today = DateTime.Now;
        }

        public TodaySales()
        {
            Today = DateTime.Now;
        }
    }
}
