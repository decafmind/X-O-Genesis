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
            tableName = "category";
            id = "id";
            fieldsname = new string[] {
                "category_name",
            };
        }

        public bool createNewCategory(string category_name)
        {
            return create(insertValues(category_name));
        }

        public List<string> getListOfCategory()
        {
            return getList("category_name");
        }

        public string getCategoryNameFromId(int id)
        {
            return (string)readScalar("category_name", " id = " + id);
        }

        public int getCategoryIndexFromName(string name)
        {
            return (int)readScalar("id", " category_name = '" + name + "'");
        }
    }
}
