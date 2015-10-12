using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class CategoryMapper : DatabaseMapper
    {
        public CategoryMapper(MySqlDB db)
            : base(db)
        {
            tableName = "category_tbl";
            id = "id";
            fieldsname = new string[] {
                "name",
            };
        }

        public bool createNewCategory(string category_name)
        {
            return create(insertValues(category_name));
        }

        public List<string> getListOfCategory()
        {
            return getList("name");
        }

        public string getCategoryNameFromId(int id)
        {
            return (string)readScalar("name", " id = " + id);
        }

        public int getCategoryIndexFromName(string name)
        {
            return (int)readScalar("id", "name = '" + name + "'");
        }
    }
}
