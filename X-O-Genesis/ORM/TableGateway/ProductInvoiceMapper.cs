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

        public List<string> getListOfProductOnInvoice(Invoice invoice)
        {
            return getList("invoice_id", string.Format("invoice_id = {0}", invoice.InvoiceId));
        }

        public bool consumeProductInvoice(ProductInvoice productInvoice)
        {
            string condition = string.Format("invoice_id = {0}", productInvoice.invoice.InvoiceId);
            return update(updateSet(condition, "consumed = 1"));
        }

        public bool checkIfAlreadyConsumed(ProductInvoice productInvoice)
        {
            object foo = readScalar("id", string.Format("invoice_id = {0} AND consumed= 1", productInvoice.invoice.InvoiceId));
            if (foo != null)
                return true;
            else
                return false;
        }


        public List<ProductInvoice> getListOfProductInvoice(Invoice invoice)
        {
            List<ProductInvoice> productInvoices = new List<ProductInvoice>();
            List<Entity> entities = getListOfEntity(string.Format("invoice_id = {0}", invoice.InvoiceId));
            foreach (Entity entity in entities)
            {
                productInvoices.Add(new ProductInvoice(entity));
            }
            return productInvoices;
        }
    }
}
