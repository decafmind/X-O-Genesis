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
            id = "id";
            fieldsname = new string[] {
                "id",
                "serial_code",
                "name",
                "description",
                "supplier_id",
                "unit",
                "unit_cost",
                "unit_price",
                "maintaining_stocks",
                "warranty",
                "replacement",
                "category_id",
                "archive",
            };
        }

        public string getInsertQuery(Product product)
        {
            return insertValues(
                product.Barcode,
                product.SerialCode,
                product.Name,
                product.Description,
                product.SupplierId,
                product.Unit,
                product.UnitCost,
                product.UnitPrice,
                product.MaintainingStocks,
                product.Warranty,
                product.Replacement,
                product.Category_id,
                product.Archive
                );
        }

        public bool deactiveProduct(string barcode){
            string condition = String.Format(" id = '{0}' ", barcode);
            updateSet(condition, "archive = '1'");
            return update(updateQuery);
        }

        public Product getProductFromName(string name)
        {
            return new Product(getEntityWhere(String.Format("name = '{0}'", name)));
        }

        public Product getProductFromBarcode(string barcode)
        {
            return new Product(getEntityFromId(barcode));
        }

        public bool updateProduct(Product origProduct, Product updatedProduct)
        {
            if (origProduct.Barcode != updatedProduct.Barcode || origProduct.Equals(updatedProduct))
                return false;

            string desc = string.Empty, unitPrice = string.Empty, category = string.Empty, manufacturer = string.Empty, specs = string.Empty,
                warranty = string.Empty, replacement = string.Empty, serialCode = string.Empty, supplierID = string.Empty, unit = string.Empty,
                unitCost = string.Empty, maintaining_unit = string.Empty;

            if (origProduct.Name != updatedProduct.Name)
                desc = string.Format("name = '{0}'", updatedProduct.Name);
            if (origProduct.UnitPrice != updatedProduct.UnitPrice)
                unitPrice = string.Format("unit_price = {0}", updatedProduct.UnitPrice);
            if (origProduct.Company != updatedProduct.Company)
                manufacturer = string.Format("source_company_name = '{0}'", updatedProduct.Company);
            if (origProduct.Category_id != updatedProduct.Category_id)
                category = string.Format("category_id = {0}", updatedProduct.Category_id);
            if (origProduct.Description != updatedProduct.Description)
                specs = string.Format("description = '{0}'", updatedProduct.Description);
            if (origProduct.Warranty != updatedProduct.Warranty)
                warranty = string.Format("warranty = '{0}'", updatedProduct.Warranty);
            if (origProduct.Replacement != updatedProduct.Replacement)
                replacement = string.Format("replacement = '{0}'", updatedProduct.Replacement);
            if (origProduct.SerialCode != updatedProduct.SerialCode)
                serialCode = string.Format("serial_code = '{0}')", updatedProduct.SerialCode);
            if (origProduct.SupplierId != updatedProduct.SupplierId)
                supplierID = string.Format("supplier_id = {0})", updatedProduct.SupplierId);
            if (origProduct.Unit != updatedProduct.Unit)
                unit = string.Format("unit = '{0}'", updatedProduct.Unit);
            if (origProduct.UnitCost != updatedProduct.UnitCost)
                unitCost = string.Format("unit_cost = {0}", updatedProduct.UnitCost);
            if (origProduct.MaintainingStocks != updatedProduct.MaintainingStocks)
                maintaining_unit = string.Format("maintaining_stocks = {0}", updatedProduct.MaintainingStocks);

            string condition = string.Format("id = '{0}'", origProduct.Barcode);

            return update(
                updateSet(condition, desc, unitPrice, category, manufacturer, specs, warranty, replacement,
                serialCode, supplierID, unit, unitCost, maintaining_unit)
                );
        }
    }


}
