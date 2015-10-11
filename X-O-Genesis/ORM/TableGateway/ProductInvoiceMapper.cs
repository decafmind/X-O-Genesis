using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductInvoiceMapper : DatabaseMapper
    {
        public ProductInvoiceMapper(MySqlDB db)
            : base(db)
        {
            tableName = "product_invoice_tbl";
            id = "id";
            fieldsname = new string[] {
                "invoice_id",
                "product_id",
                "quantity",
                "subtotal",
            };
        }

        public bool insertProductInvoice(Invoice transaction, Product product, int quantity)
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

        public bool insertProductInvoice(ProductInvoice productInvoice)
        {
            return insertProductInvoice(productInvoice.invoice, productInvoice.product, productInvoice.QuantitySold);
        }

    }
}
