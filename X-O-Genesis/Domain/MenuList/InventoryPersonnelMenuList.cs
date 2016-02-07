using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class InventoryPersonnelMenuList : MenuList
    {
          public InventoryPersonnelMenuList(MasterController masterController, MenuBar menuBar):base(masterController)
        {
            menuControls = new List<MenuControl> { 
                 new MenuControl(new InventoryView(masterController), menuBar),
            }; 
        }
    }
}
