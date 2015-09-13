using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class MedicalTransactionMapper : DatabaseMapper
    {
        public MedicalTransactionMapper(MySqlDB db)
            : base(db)
        {
            tableName = "medical_transaction_tbl";
            fieldsname = new string[] {
                "medical_id",
                "qty",
                "subtotal",
                "transaction_id",
            };
        }

        public bool insertMedicalTransaction(Transaction transaction, Medical medical, int qty, decimal subtotal)
        {
            return create(
                insertValues(medical.Id, qty, subtotal, transaction.TransactionId)
                );
        }
    }
}
