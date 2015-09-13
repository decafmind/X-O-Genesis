using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class EmployeeArgs
    {
        public Employee employee { get; private set; }
        public EmployeeArgs(Employee e)
        {
            employee = e;
        }
    }
}
