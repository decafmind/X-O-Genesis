using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductInspection: IEntity
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Decimal UnitPrice { get; set; }
        public string Specification { get; set; }
        public string Warranty { get; set; }
        public string Replacement { get; set; }
        public int QtyOnHand { get; set; }

        public ProductInspection()
        {

        }

        public ProductInspection(Entity entity)
        {
            try
            {
                ItemCode = (string)entity.getField("Item_Code");
                Description = (string)entity.getField("Description");
                Category = (string)entity.getField("Category");
                UnitPrice = (decimal)entity.getField("Unit_Price");
                Specification = (string)entity.getField("Specification");
                Warranty = (string)entity.getField("Warranty");
                Replacement = (string)entity.getField("Replacement_Period");
                QtyOnHand = (int)entity.getField("Quantity_On_Hand");
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is ProductInspection)
            {
                ProductInspection product = obj as ProductInspection;
                if (this.ItemCode == product.ItemCode)
                    if (this.Description == product.Description)
                        if (this.Category == product.Category)
                            if (this.UnitPrice == product.UnitPrice)
                                if (this.Specification == product.Specification)
                                    if (this.Warranty == product.Warranty)
                                        if (this.Replacement == product.Replacement)
                                            if (this.QtyOnHand == product.QtyOnHand)
                                                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
