using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    // The Set of MenuControl for the cashier.

    class CashierMenuList : MenuList
    {
        public CashierMenuList(MasterController masterController, MenuBar menuBar):base(masterController)
        {
            menuControls = new List<MenuControl> { 
                 new MenuControl(new POS(masterController), menuBar),
                 new MenuControl(new OrderPOS(masterController), menuBar),
            };
        }
    }
}
