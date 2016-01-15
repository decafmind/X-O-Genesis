using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ProductReturned
    {
        public int productInvoiceId { get; private set; }
        public int qtyReturned { get; private set; }
        public DateTime date { get; private set; }
        public string reason { get; private set; }

        public ProductReturned(int pid, int qr, DateTime d, string r)
        {
            productInvoiceId = pid;
            qtyReturned = qr;
            date = d;
            reason = r;
        }
    }
}
