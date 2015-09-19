using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Invoice : IEntity
    {
        public int InvoiceId { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string EmployeeId { get; set; }

        public Invoice()
        {

        }
    }
}
