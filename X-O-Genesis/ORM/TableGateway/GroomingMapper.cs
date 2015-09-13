using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class GroomingMapper : DatabaseMapper
    {
        public GroomingMapper(MySqlDB db)
            : base(db)
        {
            tableName = "grooming_tbl";
            id = "grooming_id";
            fieldsname = new string[] {
                "grooming_id",
                "grooming_name",
            };
            fieldsname_forselect = new string[]{
                "grooming_id",
                "grooming_name",
            };
        }

        public bool insertGrooming(Grooming grooming)
        {
            return create(insertValues("null", grooming.Name));
        }

        public List<string> getListOfGroomingServices()
        {
            return getList("grooming_name");
        }

        public int getGroomingIDFromName(string name)
        {
            string condition = string.Format("grooming_name = '{0}'", name);
            return (int)readScalar("grooming_id", condition);
        }

        public Grooming getGroomingFromId(int id)
        {
            string condition = string.Format("grooming_id = {0}", id);
            return new Grooming(getEntityWhere(condition));
        }

        public Grooming getGroomingFromName(string name)
        {
            string condition = string.Format("grooming_name = '{0}'", name);
            return new Grooming(getEntityWhere(condition));
        }

        public string createGroomingQuery(Grooming grooming)
        {
            return insertValues("null", grooming.Name);
        }

        public List<Grooming> getListOfGrooming()
        {
            List<Grooming> groomings = new List<Grooming>();
            List<Entity> entities = getListOfEntity("SELECT grooming_id, grooming_name FROM grooming_tbl");
            foreach (Entity entity in entities)
            {
                Grooming grooming = new Grooming(entity);
                groomings.Add(grooming);
            }
            return groomings;
        }

        public bool updateGrooming(Grooming oldGrooming, Grooming newGrooming)
        {
            if (oldGrooming.Name == newGrooming.Name)
                return false;

            string condition = string.Format("grooming_name = '{0}'", oldGrooming.Name);
            string grooming_name = string.Empty;
            grooming_name = string.Format("grooming_name = '{0}'", newGrooming.Name);

            return update(
                updateSet(condition, grooming_name)
                );
        }
    }
}
