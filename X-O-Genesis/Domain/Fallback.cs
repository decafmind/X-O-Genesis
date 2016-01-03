using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Fallback : IEntity
    {
        public string Squery { get; set; }
        public int ID { get; set; }

        public Fallback() 
        {

        }

        public Fallback(Entity e)
        {
            try
            {
                ID = (int)e.getField("id");
                Squery = (string)e.getField("squery");
            }
            catch
            {

            }
        }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
