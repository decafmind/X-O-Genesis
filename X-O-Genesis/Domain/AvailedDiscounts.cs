using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class AvailedDiscounts : IEntity
    {
        public int InvoiceID { get; set; }
        public int DiscountType { get; set; }
        public string DiscountTitle { get; set; }
        public decimal Less { get; set; }

        public AvailedDiscounts()
        {

        }

        public AvailedDiscounts(Entity entity)
        {
            try
            {
                InvoiceID = (int)entity.getField("invoice_id");
                DiscountType = (int)entity.getField("discount_type");
                DiscountTitle = (string)entity.getField("discount_title");
                Less = (decimal)entity.getField("less");
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }

    }
}
