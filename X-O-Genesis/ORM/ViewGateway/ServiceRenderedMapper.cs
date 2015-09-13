using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ServiceRenderedMapper : DatabaseMapper
    {
        public ServiceRenderedMapper(MySqlDB db)
            : base(db)
        {
            tableName = "service_rendered";
            fieldsname = new string[]{
                "Name",
                "Qty",
                "Subtotal",
            };
        }
    }
}
