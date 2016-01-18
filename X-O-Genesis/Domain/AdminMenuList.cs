using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetvetPOS_Inventory_System
{
    // Set of MenuControls for Admin User

    class AdminMenuList: MenuList
    {
        public AdminMenuList(MasterController masterController, MenuBar menuBar):base(masterController)
        {
            menuControls = new List<MenuControl> { 
                 new MenuControl(new Home(masterController), menuBar),
                 new MenuControl(new Sales(masterController), menuBar),
                 new MenuControl(new SystemOperation(masterController), menuBar),
                 new MenuControl(new InventoryView(masterController), menuBar),                
            }; 
        }


    }
}
