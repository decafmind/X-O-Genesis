using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class StaffMenuList : MenuList
    {
        public StaffMenuList(MasterController masterController, MenuBar menuBar):base(masterController)
        {
            menuControls = new List<MenuControl> { 
                 new MenuControl(new CustomerInformation(masterController), menuBar),
            }; 
        }
    }
}
