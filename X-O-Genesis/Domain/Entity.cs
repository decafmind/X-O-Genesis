using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    /// <summary>
    /// This class was used to get the values of a row for a table and return it as
    /// an abtract entity
    /// </summary>
   
    public class Entity : IEntity
    {
        Dictionary<string, object> fieldMap = new Dictionary<string, object>();
        public object Id { get; set; }
        public string[] fieldsname { get; set; }

        public Entity()
        {

        }

        public Entity(object id, string[] fieldsname)
        {
            this.Id = id;
            this.fieldsname = fieldsname;
        }

        public void setField(string fieldname, object value)
        {
            fieldMap.Add(fieldname, value);
        }

        public object getField(string fieldname)
        {
            if (fieldMap.ContainsKey(fieldname))
                return fieldMap[fieldname];
            else
                return null;
        }

    }
}
