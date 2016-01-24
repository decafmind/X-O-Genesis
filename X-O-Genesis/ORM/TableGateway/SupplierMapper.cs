using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class SupplierMapper : DatabaseMapper
    {
        public SupplierMapper(MySqlDB db)
            : base(db)
        {
            id = "id";
            tableName = "supplier_tbl";
            fieldsname = new string[]{
                "name",
                "address",
                "contact_number",
                "contact_person",
            };
        }

        bool createSupplier(Supplier supplier)
        {
            return create(
                    insertValues(supplier.Name, supplier.Address, supplier.ContactNo, supplier.ContactPerson)
                );

        }

        public string getSupplierNameFromId(int id)
        {
            return (string)readScalar("name", " id = " + id);
        }

        public List<string> getSupplierList()
        {
            return getList("name");
        }

        public int getSupplierIdByName(string name)
        {
            return (int)readScalar("id", "name = '" + name + "'");
        }
    }
}
