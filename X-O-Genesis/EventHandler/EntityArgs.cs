using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class EntityArgs
    {
        public IEntity Entity { get; set; }

        public EntityArgs(IEntity entity)
        {
            this.Entity = entity;
        }
    }
}
