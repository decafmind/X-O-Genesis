using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Transaction : IEntity
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string UserId { get; set; }

        public Transaction()
        {

        }
    }
}
