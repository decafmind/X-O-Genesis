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
        public string SerialCode { get; set; }
        public int SupplierId { get; set; }
        public int MaintainingStocks { get; set; }
        public Decimal UnitCost { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal UnitPrice { get; set; }
        public int Category_id { get; set; }
        public string Category { get; set; }
        public int Company { get; set; }
        public string Warranty { get; set; }
        public string SupplierName { get; set; }
        public string Archive = "0";

        public string Replacement { get; set; }

        public Product()
        {

        }

        public Product(Entity entity, bool isFromInventoryView = false)
        {
            try
            {
                if (isFromInventoryView)
                {
                    Barcode = (string)entity.getField("Barcode");
                    Name = (string)entity.getField("Name");
                    Category = (string)entity.getField("Category");
                    UnitCost = (decimal)entity.getField("UnitCost");
                    UnitPrice = (decimal)entity.getField("Unit_price");
                    Description = (string)entity.getField("Description");
                    Warranty = (string)entity.getField("Warranty");
                    Replacement = (string)entity.getField("Replacement");
                    Description = (string)entity.getField("Description");
                    SupplierName = (string)entity.getField("Supplier");
                    SerialCode = (string)entity.getField("SerialCode");
                    Unit = (string)entity.getField("Unit");
                    MaintainingStocks = (int)entity.getField("MaintainingStocks");
                }
                else
                {
                    Barcode = (string)entity.getField("id");
                    Name = (string)entity.getField("name");
                    Description = (string)entity.getField("description");
                    SupplierId = (int)entity.getField("supplier_id");
                    Unit = (string)entity.getField("unit");
                    UnitCost = (decimal)entity.getField("unit_cost");
                    UnitPrice = (decimal)entity.getField("unit_price");
                    MaintainingStocks = (int)entity.getField("maintaining_stocks");
                    Warranty = (string)entity.getField("warranty");
                    Replacement = (string)entity.getField("replacement");
                    Category_id = (int)entity.getField("category_id");
                    SerialCode = (string)entity.getField("serial_code");
                }
                 
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
                    if (this.Name == product.Name)
                        if (this.Category_id == product.Category_id)
                            if (this.UnitPrice == product.UnitPrice)
                                if (this.Company == product.Company)
                                    if (this.Warranty == product.Warranty)
                                        if (this.Replacement == product.Replacement)
                                            if (this.Description == product.Description)
                                                if (this.MaintainingStocks == product.MaintainingStocks)
                                                    if (this.SerialCode == product.SerialCode)
                                                        if (this.Unit == product.Unit)
                                                            if (this.UnitCost == product.UnitCost)
                                                                if (this.UnitPrice == product.UnitPrice)
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
