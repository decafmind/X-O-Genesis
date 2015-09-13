using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Medical : Service, IEntity
    {
        public Medical(string name):base(name)
        {
            this.Name = name;
        }

        public Medical()
        {

        }

        public Medical(Entity entity)
        {
            try
            {
                int id = 0;
                if (int.TryParse(entity.getField("medical_id").ToString(), out id))
                    Id = id;
                Name = entity.getField("medical_name").ToString();
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }
    }
}
