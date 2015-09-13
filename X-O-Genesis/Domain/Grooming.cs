using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Grooming : Service, IEntity
    {
        public Grooming(string name, decimal price):base(name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        public Grooming()
        {

        }

        public Grooming(Entity entity)
        {
            try
            {
                Id = (int)entity.getField("grooming_id");
                Name = entity.getField("grooming_name").ToString();
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }
    }
}
