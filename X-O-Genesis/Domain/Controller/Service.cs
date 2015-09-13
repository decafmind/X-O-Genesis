using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Service()
        {

        }

        public Service(string name)
        {
            this.Name = name;
        }
    }
}
