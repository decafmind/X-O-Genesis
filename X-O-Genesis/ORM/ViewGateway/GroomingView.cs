using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class GroomingView : DatabaseMapper
    {
        public GroomingView(MySqlDB db)
            : base(db)
        {
            tableName = "grooming_view";
            fieldsname = new string[]{
                "grooming_name",
                "petsize",
                "price",
            };
            fieldsname_forselect = new string[]{
                "grooming_name AS 'Grooming Name'",
                "petsize AS Petsize",
                "price AS Price",
            };
        }
    }
}
