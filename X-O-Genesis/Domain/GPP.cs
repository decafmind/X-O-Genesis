using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class GPP : Service, IEntity
    {
        public int grooming_id { get; set; }
        public Petsize petsize { get; set; }
        public decimal price { get; set; }

        public GPP()
        {

        }

        public GPP(Entity entity)
        {
            try
            {
                Id = (int)entity.getField("id");
                grooming_id = (int)entity.getField("grooming_id");
                price = (decimal)entity.getField("price");
                petsize = (Petsize)entity.getField("petsize_id");
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }
    }
}
