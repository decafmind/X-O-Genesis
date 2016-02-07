using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    // Base class for Set of MenuControl

    abstract class MenuList
    {
        protected MasterController masterController;
        protected List<MenuControl> menuControls;
    
        public MenuList(MasterController masterController)
        {
            this.masterController = masterController;
        }

        public List<MenuControl> getList
        {
            get
            {
                return menuControls;
            }
        }
    }
}
