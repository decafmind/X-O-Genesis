using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string ContactPerson { get; set; }

        public Supplier()
        {

        }

        public Supplier(Entity entity)
        {
            ID = (int)entity.getField("id");
            Name = (string)entity.getField("name");
            Address = (string)entity.getField("address");
            ContactNo = (string)entity.getField("contact_number");
            ContactPerson = (string)entity.getField("contact_person");
        }
    }
}
