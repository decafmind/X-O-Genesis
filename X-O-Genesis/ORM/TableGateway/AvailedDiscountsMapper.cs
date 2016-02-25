using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class AvailedDiscountsMapper : DatabaseMapper
    {
        public AvailedDiscountsMapper(MySqlDB db)
            : base(db)
        {
            tableName = "availed_discounts_tbl";
            id = "id";
            fieldsname = new string[] {
                "invoice_id",
                "discount_type",
                "discount_title",
                "less",
            };
        }

        public bool insertAvailedDiscounts(AvailedDiscounts availedDiscounts)
        {
            return create(insertValues(availedDiscounts.InvoiceID, availedDiscounts.DiscountType,
                availedDiscounts.DiscountTitle, availedDiscounts.Less));
        }
        public List<AvailedDiscounts> getAvailedDiscountsByInvoiceID(Invoice invoice)
        {
            string condition = String.Format("invoice_id = '{0}'", invoice.InvoiceId);
            List<AvailedDiscounts> availedDiscounts = new List<AvailedDiscounts>();
            List<Entity> entities = getListOfEntity(condition);
            foreach (Entity entity in entities)
            {
                availedDiscounts.Add(new AvailedDiscounts(entity));
            }
            return availedDiscounts;
        }
    }
}
