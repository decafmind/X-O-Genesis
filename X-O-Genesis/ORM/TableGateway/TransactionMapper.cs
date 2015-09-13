using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class TransactionMapper : DatabaseMapper
    {
        public TransactionMapper(MySqlDB db):base(db)
        {
            tableName = "transaction_tbl";
            id = "transaction_id";
            fieldsname = new string[] {
                "transaction_date",
                "transaction_time",
                "user_id",
            };
        }

        public int getTransactionId(Transaction transaction)
        {
            string condition = String.Format("transaction_date = {0} and user_id = '{1}' ORDER BY transaction_time DESC", 
                "CURDATE()", 
                transaction.UserId);
            return (int)readScalar("transaction_id", condition);
        }

        public bool insertTransaction(Transaction transaction)
        {
            return create(insertValues(
                "CURDATE()",
                "CURTIME()",
                transaction.UserId)
                );
        }
    }
}
