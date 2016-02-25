using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductInvoice: IEntity
    {
        public Product product { get; set; }
        public Invoice invoice { get; set; }
        public int QuantitySold { get; set; }
        public Decimal GroupPrice { get; set; }
        public DateTime date { get; set; }
        public Decimal DiscPercent { get; set; }
        public Decimal DiscFixed { get; set; }

        public ProductInvoice()
        {

        }

        public ProductInvoice(Entity entity)
        {
            invoice = new Invoice()
            {
                InvoiceId = (int)entity.getField("invoice_id"),
            };

            product = new Product()
            {
                Barcode = entity.getField("product_id").ToString(),
            };

            QuantitySold = (int)entity.getField("quantity");
            GroupPrice = (Decimal)entity.getField("subtotal");
            DiscPercent = (Decimal)entity.getField("discount_percent");
            DiscFixed = (Decimal)entity.getField("discount_fixed");
        }
    }
}
