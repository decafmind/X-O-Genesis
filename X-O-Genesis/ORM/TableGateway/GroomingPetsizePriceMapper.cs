using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class GroomingPetsizePriceMapper: DatabaseMapper
    {
        public GroomingPetsizePriceMapper(MySqlDB db)
            : base(db)
        {
            tableName = "grooming_petsize_price_tbl";
            id = "id";
            fieldsname = new string[] {
                "id",
                "grooming_id",
                "petsize_id",
                "price",
            };
        }

        public bool insertGPP(Grooming grooming, Petsize size, decimal price){
            return create(insertValues("null", grooming.Id, (int)size, price));
        }


        public string createGPPQuery(Grooming grooming, Petsize size, decimal price)
        {
            return insertValues("null", grooming.Id, (int)size, price);
        }

        public decimal getPriceFromGroomingSize(Grooming grooming, Petsize size)
        {
            string condition = string.Format(" grooming_id = {0} AND petsize_id = {1}", grooming.Id, (int)size);
            object price = readScalar("price",condition);
            if(price != null)
                return (decimal)price;
            else
                return 0;
        }

        public GPP getGPPFromGroomingSize(Grooming grooming, Petsize size)
        {
            string condition = string.Format("grooming_id = {0} AND petsize_id = {1}", grooming.Id, (int)size);
            Entity entity = getEntityWhere(condition);
            return new GPP(entity);
        }

        public bool updateGroomingPrice(GPP oldGpp, GPP newGPP)
        {
            if (oldGpp.price == newGPP.price)
                return false;

            string condition = string.Format("id = {0}", oldGpp.Id);
            string price = string.Empty;
            price = string.Format("price = {0}", newGPP.price);

            return update(
                updateSet(condition, price)
                );

        }


    }
}
