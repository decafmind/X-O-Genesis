using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class GppTransactionMapper: DatabaseMapper
    {
        public GppTransactionMapper(MySqlDB db)
            : base(db)
        {
            tableName = "gpp_transaction_tbl";
            id = "gpp_transaction_id";
            fieldsname = new string[]{
                "transaction_id",
                "gpp_id",
                "qty",
                "subtotal",
            };
        }

        public bool insertGpp(Transaction transaction, GPP gpp, int quantity, decimal subtotal)
        {
            return create(
                insertValues(transaction.TransactionId, gpp.Id, quantity, subtotal)
                );
        }
    }
}
