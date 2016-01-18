using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductInventoryDomain
    {
        public Product product { get; private set; }
        public Inventory inventory { get; private set; }

        public ProductInventoryDomain(Product product, Inventory inventory)
        {
            this.product = product;
            this.inventory = inventory;
        }
    }
}
