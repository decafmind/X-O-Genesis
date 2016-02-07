using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System.Domain
{
    public class Theme
    {
        public String Name { get; set; }
        public Color HeaderColor { get; set; }
        public Color IconColor { get; set; }
        public Color SideBarColor { get; set; }

        public Theme() { }
        public Theme(String name, Color headerColor, Color iconColor, Color sideBarColor)
        {
            Name = name;
            HeaderColor = headerColor;
            IconColor = iconColor;
            SideBarColor = sideBarColor;
        }

        public void Save(MasterController masterController)
        {
            if (HeaderColor != null)
                Properties.Settings.Default.headerColor = HeaderColor;
            if (IconColor != null)
                Properties.Settings.Default.iconColor = IconColor;
            if (SideBarColor != null)
                Properties.Settings.Default.sidebarColor = SideBarColor;

            Properties.Settings.Default.Save();
            SettingArgs s = new SettingArgs(Settings.PERSONALIZATION);
            masterController.OnSettingsChanged(s);
        }

    }
}
