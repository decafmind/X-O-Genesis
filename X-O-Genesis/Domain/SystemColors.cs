using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PetvetPOS_Inventory_System
{
    public struct SystemColors
    {
        /// <summary>
        /// Struct for commonly use colors in the system
        /// </summary>
        /// 
        public static Color menuBarBlue = getColorFromArgb(67, 119, 131);
        public static Color menuLightBlue = getColorFromArgb(106, 148, 157);
        public static Color menuDarkBlue = getColorFromArgb(50, 100, 120);
        public static Color posGray = getColorFromArgb(160, 158, 158);

        public static Color inventoryRosy = getColorFromArgb(254, 169, 169);
        public static Color loginDullYellow = getColorFromArgb(250, 255, 189);
        public static Color subHeaderGreen = getColorFromArgb(126, 190, 143);
        public static Color headerGreen = getColorFromArgb(79, 158, 99);

        // Jet Black Theme
        public static Color jetBlackTitleBar = getColorFromArgb(42, 42, 42);
        public static Color menuBarBlack = getColorFromArgb(125, 126, 125);
        public static Color menuSilver = Color.Silver;

        public static Color getColorFromArgb(int r, int g, int b)
        {
            return Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b)))));
        }
    }
}
