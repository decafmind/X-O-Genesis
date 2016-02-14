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

        public bool createSupplier(Supplier supplier)
        {
            return create(
                    insertValues(supplier.Name, supplier.Address, supplier.ContactNo, supplier.ContactPerson)
                );
        }

        public bool removeSupplier(int id)
        {
            return update(
                    updateSet(string.Format("id = {0}", id), "archive = 1")
                );
        }

        public bool updateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            string name = string.Empty, address = string.Empty, number = string.Empty, person = string.Empty;
            if (oldSupplier.Name != newSupplier.Name)
                name = string.Format("name = '{0}'", name);
            if (oldSupplier.Address != newSupplier.Address)
                address = string.Format("address = '{0}'", address);
            if (oldSupplier.ContactNo != newSupplier.ContactNo)
                number = string.Format("contact_number = '{0}'", newSupplier.ContactNo);
            if (oldSupplier.ContactPerson != newSupplier.ContactPerson)
                person = string.Format("contact_person = '{0}'", newSupplier.ContactPerson);

            int id = getSupplierIdByName(newSupplier.Name);
            return update(
                    updateSet(string.Format("id = {0}", id), 
                        name, address, number, person
                        )
                );
        }

        public string getSupplierNameFromId(int id)
        {
            return (string)readScalar("name", " id = " + id);
        }

        public List<string> getSupplierList()
        {
            return getList("name", "archive = 0");
        }

        public int getSupplierIdByName(string name)
        {
            try
            {
                return (int)readScalar("id", "name = '" + name + "'");
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        public Supplier getSupplierByName(string name)
        {
            int supplierId = getSupplierIdByName(name);
            return new Supplier(getEntityFromId(supplierId));
        }
    }
}
