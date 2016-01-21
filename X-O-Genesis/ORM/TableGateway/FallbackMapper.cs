using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class FallbackMapper : DatabaseMapper
    {
        public FallbackMapper(MySqlDB db)
            : base(db)
        {
            tableName = "fallback_tbl";
            id = "id";
            fieldsname = new string[] {
                "id",
                "squery",
            };
        }

        public List<string> getListOfSquery()
        {
            return getList("squery");
        }

    }
}
