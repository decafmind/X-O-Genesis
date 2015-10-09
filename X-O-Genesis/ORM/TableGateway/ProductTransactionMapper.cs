using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductTransactionMapper: DatabaseMapper
    {
        public ProductTransactionMapper(MySqlDB db)
            : base(db)
        {
            tableName = "product_transaction_tbl";
            id = "transaction_id";
            fieldsname = new string[] {
                "transaction_id",
                "barcode",
                "qty_sold",
                "grp_price",
            };
        }

        public bool insertProductTransaction(Invoice transaction, Product product, int quantity)
        {
            Decimal grpPrice = product.UnitPrice * quantity;
            return create(
                insertValues(transaction.InvoiceId, product.Barcode, quantity, grpPrice)
                );
        }

        public bool updateDescription(string barcode, string newDescription)
        {
            string condition = String.Format("barcode = '{0}' ", barcode);
            updateSet(condition, String.Format("description = '{0}'", newDescription));
            return update(updateQuery);
        }

        //public bool updateQtySoldAndGrpPrice(string transaction_id, decimal grp_price)
        //{
        //    string condition = String.Format("transaction_id = '{0}' ", barcode);
        //    updateSet(condition, String.Format("description = '{0}'", newDescription));
        //    return update(updateQuery);
        //}

        public bool insertProductTransaction(ProductTransaction productTransaction)
        {
            return insertProductTransaction(productTransaction.invoice, productTransaction.product, productTransaction.QuantitySold);
        }


    }
}
