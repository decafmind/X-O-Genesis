using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Product: IEntity
    {
        public string Barcode { get; set; }
        public string Description { get; set; }
        public Decimal UnitPrice { get; set; }
        public int Category_id { get; set; }
        public int Company { get; set; }
        public string Warranty { get; set; }
        public string Specification { get; set; }
        public string Replacement { get; set; }
        public Product()
        {

        }

        public Product(Entity entity)
        {
            try
            {
                 Barcode = (string)entity.getField("id");
                 Description = (string)entity.getField("name");
                 UnitPrice = (decimal)entity.getField("unit_price");
                 Warranty = (string)entity.getField("warranty");
                 Specification = (string)entity.getField("specification");
                 Replacement = (string)entity.getField("replacement");
                 Category_id = (int)entity.getField("category_id");
                // Company = (int)entity.getField("supplier");
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                Product product = obj as Product;
                if (this.Barcode == product.Barcode)
                    if (this.Description == product.Description)
                        if (this.Category_id == product.Category_id)
                            if (this.UnitPrice == product.UnitPrice)
                                if (this.Company == product.Company)
                                    if (this.Warranty == product.Warranty)
                                        if (this.Replacement == product.Replacement)
                                            if (this.Specification == product.Specification)
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
