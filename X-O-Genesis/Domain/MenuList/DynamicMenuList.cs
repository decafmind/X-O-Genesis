using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    class DynamicMenuList: MenuList
    {
        MenuBar menuBar;

        public DynamicMenuList(MasterController masterController, MenuBar menuBar) : base(masterController) { this.menuBar = menuBar; }
       
        public void Add(IContentPage page)
        {
            menuControls.Add(new MenuControl(page, menuBar));
        }
    }
}
