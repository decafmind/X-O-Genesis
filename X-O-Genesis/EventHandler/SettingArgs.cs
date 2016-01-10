using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class SettingArgs
    {
        public Settings settings { get; set; }
        public SettingArgs(Settings settings)
        {
            this.settings = settings;
        }
    }
}
