using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class SimpleCashierMenuList: MenuList
    {
        public SimpleCashierMenuList(MasterController masterController, MenuBar menuBar)
            : base(masterController)
        {
            menuControls = new List<MenuControl> { 
                 new MenuControl(new OrderPOS(masterController), menuBar),
            };
        }
    }
}
