using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class SystemSettingMapper : DatabaseMapper
    {
        public SystemSettingMapper(MySqlDB db)
            : base(db)
        {
            tableName = "system_settings_tbl";
            fieldsname = new string[]{
                "name",
                "value",
            };
        }

        public bool updateSettings(string name, string value)
        {
            string condition = string.Format("name = '{0}'", name);
            string updateValue = string.Format("value = '{0}'", value);
            return update(updateSet(condition, updateValue));
        }

        public string getValue(string name)
        {
            return (string)readScalar("value", string.Format("name = '{0}'", name));
        }

        public bool isInSimpleMode()
        {
            bool SimpleMode = true;
            string mode = getValue("mode");

            if (mode == "simple")
                SimpleMode = true;
            else if (mode == "advance")
                SimpleMode = false;
            else
                SimpleMode = true;

            return SimpleMode;
        }
    }
}
