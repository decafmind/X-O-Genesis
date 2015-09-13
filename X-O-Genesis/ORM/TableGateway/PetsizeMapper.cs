using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class PetsizeMapper : DatabaseMapper
    {
        public PetsizeMapper(MySqlDB db):base(db){
            tableName = "petsize_tbl";
            id = "id";
            fieldsname = new string[]{
                "petsize",
            };
        }

        public Petsize getPetsizeFromName(string name)
        {
            return (Petsize)readScalar("id", string.Format("petsize = '{0}'", name));
        }


    }
}
