using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class TransactionResult: DatabaseMapper
    {
        public TransactionResult(MySqlDB db)
            : base(db)
        {
            tableName = "receipt_tbl";
            id = "id";
            fieldsname = new string[] {
                "invoice_id",
                "net_price",
                "cash_tender",
                "changed",
            };
        }

        public bool insertTransactionResult(Invoice transaction, Decimal totalPrice, Decimal cashTender)
        {
            if (transaction != null)
            {
                Decimal change = cashTender - totalPrice;
                return create(
                    insertValues(transaction.InvoiceId, totalPrice, cashTender, change)
                );
            }
            return false;
        }

        public bool updateTotalPrice(string transaction_id,  decimal new_total_price)
        {
            string condition = String.Format("invoice_id = {0} ", transaction_id);
            updateSet(condition, String.Format("net_price = {0}", new_total_price));
            return update(updateQuery);
        }

    }
}
