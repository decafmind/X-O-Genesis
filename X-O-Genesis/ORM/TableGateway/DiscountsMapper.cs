using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class DiscountsMapper : DatabaseMapper
    {
        private const int DEFAULT_FLAG = 1;
        public DiscountsMapper(MySqlDB db)
            : base(db)
        {
            tableName = "discounts_tbl";
            id = "id";
            fieldsname = new string[]{
                "type",
                "title",
                "descrpt",
                "less",
                "flag",
            };
            fieldsname_forselect = new string[]{
                "id",
                "type",
                "title",
                "descrpt",
                "less",
                "flag",
            };
        }
        public Discounts getDiscountDetailsFromTitle(string title)
        {
            string condition = String.Format("title = '{0}'", title);
            return new Discounts(getEntityWhere(condition));
        }

        public bool addNewDiscount(Discounts discount)
        {
            return create(insertValues(discount.Type, discount.Title, discount.Desc, 
                discount.Less, DEFAULT_FLAG));
        }

        public bool updateDiscount(Discounts discount)
        {
            string condition = String.Format("title = '{0}'", discount.Title);
            string type, title, desc, less, flag;
            type = String.Format("type = {0}", discount.Type);
            title = String.Format("title = '{0}'", discount.Title);
            desc = String.Format("descrpt = '{0}'", discount.Desc);
            less = String.Format("less = {0}", discount.Less);
            flag = String.Format("flag = '{0}'", discount.Flag);

            return update(updateSet(condition, type, title, desc, less, flag));
        }

        public bool deleteDiscount(Discounts discount)
        {
            string condition = String.Format("title = '{0}'", discount.Title);
            string type, title, desc, less, flag;
            type = String.Format("type = {0}", discount.Type);
            title = String.Format("title = '{0}'", discount.Title);
            desc = String.Format("descrpt = '{0}'", discount.Desc);
            less = String.Format("less = {0}", discount.Less);
            flag = String.Format("flag = '{0}'", discount.Flag);

            return update(updateSet(condition, type, title, desc, less, flag));
        }
    }
}
