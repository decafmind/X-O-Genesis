using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class InvoiceMapper : DatabaseMapper
    {
        public InvoiceMapper(MySqlDB db):base(db)
        {
            tableName = "invoice_tbl";
            id = "id";
            fieldsname = new string[] {
                "date",
                "time",
                "employee_id",
            };
        }

        public int getTransactionId(Invoice transaction)
        {
            string condition = String.Format("transaction_date = {0} and user_id = '{1}' ORDER BY transaction_time DESC", 
                "CURDATE()", 
                transaction);
            return (int)readScalar("transaction_id", condition);
        }

        public bool insertTransaction(Invoice transaction)
        {
            return create(insertValues(
                "CURDATE()",
                "CURTIME()",
                transaction.EmployeeId)
                );
        }
    }
}
