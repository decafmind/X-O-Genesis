using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class MedicalMapper : DatabaseMapper
    {
        public MedicalMapper(MySqlDB db)
            : base(db)
        {
            tableName = "medical_tbl";
            id = "medical_id";
            fieldsname = new string[] {
                "medical_id",
                "medical_name",
            };
            fieldsname_forselect = new string[]{
                "medical_name AS 'Medical Name'",
            };
        }

        public bool insertMedical(Medical medical)
        {
            return create(insertValues("null", medical.Name));
        }

        public List<string> getListOfMedicalService()
        {
            return getList("medical_name");
        }

        public Medical getMedicalFromId(int id)
        {
            string condition = string.Format("medical_id = {0}", id);
            return new Medical(getEntityWhere(condition));
        }

        public Medical getMedicalFromName(string name)
        {
            string condition = string.Format("medical_name = '{0}'", name);
            return new Medical(getEntityWhere(condition));
        }

        public bool updateMedical(Medical oldMedical, Medical newMedical)
        {
            if (oldMedical.Name == newMedical.Name)
                return false;

            string condition = string.Format(" medical_name = '{0}'", oldMedical.Name);
            string medical_name = string.Format(" medical_name = '{0}'", newMedical.Name);
            return update(
                updateSet(condition, medical_name)
                );

        }
    }
}
