using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductTransaction: IEntity
    {
        public Product product { get; set; }
        public Invoice invoice { get; set; }
        public int QuantitySold { get; set; }
        public Decimal GroupPrice { get; set; }

        public ProductTransaction()
        {

        }
    }
}
