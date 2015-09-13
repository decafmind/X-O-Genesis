using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class UserArgs
    {
        public User User { get; private set; }

        public UserArgs(User user)
        {
            User = user;
        }

        //
    }
}
