using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Discounts: IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public string Desc { get; set; }
        public Decimal Less { get; set; }
        public int Flag { get; set; }
        
        public Discounts()
        {
        }
         public Discounts(Entity e)
         {
            try
            {
                Title = (string)e.getField("title");
                Type = (int)e.getField("type");
                Desc = (string)e.getField("descrpt");
                Less = (decimal)e.getField("less");
                Flag = (int)e.getField("flag");
            }
            catch (Exception ex)
            {

            }
         }
         public override string ToString()
         {
             return ID.ToString();
         }
    }
}
