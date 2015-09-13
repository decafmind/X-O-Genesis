using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductMapper: DatabaseMapper
    {
        public ProductMapper(MySqlDB db)
            : base(db)
        {
            tableName = "product_tbl";
            id = "barcode";
            fieldsname = new string[] {
                "barcode",
                "description",
                "unit_price",
                "category",
                "source_company_name",
            };
        }

        public bool deactiveProduct(string barcode){
            string condition = String.Format(" barcode = '{0}' ", barcode);
            updateSet(condition, "active = 0");
            return update(updateQuery);
        }

        public bool updateDescription(string barcode, string newDescription)
        {
            string condition = String.Format("barcode = '{0}' ", barcode);
            updateSet(condition, String.Format("description = '{0}'", newDescription));
            return update(updateQuery);
        }

        public bool updateUnitPrice(string barcode, decimal newPrice)
        {
            string condition = String.Format("barcode = '{0}'", barcode);
            updateSet(condition, String.Format("unit_price = {0}", newPrice));
            return update(updateQuery);
        }

        public bool updateCategory(string barcode, string newCategory)
        {
            string condition = String.Format("barcode = '{0}'", barcode);
            updateSet(condition, String.Format("category = '{0}'", newCategory));
            return update(updateQuery);
        }

        public bool updateSourceCompanyName(string barcode, string company)
        {
            string condition = String.Format("barcode = '{0}'", barcode);
            updateSet(condition, String.Format("source_company_name = '{0}'", company));
            return update(updateQuery);
        }

        public string createProduct(Product product)
        {
            return insertValues(
                product.Barcode, product.Description, product.UnitPrice,
                product.Category, product.Company);
        }

        public Product getProductFromName(string name)
        {
            return new Product(getEntityWhere(String.Format("description = '{0}'", name)));
        }

        public Product getProductFromBarcode(string barcode)
        {
            return new Product(getEntityFromId(barcode));
        }

        public bool updateProduct(Product origProduct, Product updatedProduct)
        {
            if (origProduct.Barcode != updatedProduct.Barcode || origProduct.Equals(updatedProduct))
                return false;

            string desc = string.Empty, unitPrice = string.Empty, category = string.Empty, manufacturer = string.Empty;

            if (origProduct.Description != updatedProduct.Description)
                desc = string.Format("description = '{0}'", updatedProduct.Description);
            if (origProduct.UnitPrice != updatedProduct.UnitPrice)
                unitPrice = string.Format("unit_price = {0}", updatedProduct.UnitPrice);
            if (origProduct.Company != updatedProduct.Company)
                manufacturer = string.Format("source_company_name = '{0}'", updatedProduct.Company);
            if (origProduct.Category != updatedProduct.Category)
                category = string.Format("category = '{0}'", updatedProduct.Category);

            string condition = string.Format("barcode = '{0}'", origProduct.Barcode);

            return update(
                updateSet(condition, desc, unitPrice, category, manufacturer)
                );
        }
    }


}
