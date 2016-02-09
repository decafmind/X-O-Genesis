using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class Path
    {
        public static string formatImagePath(string path)
        {
            string newString = "";
            char backSlash = '\\';

            if (path.Contains(backSlash))
            {
                string[] parseOfString = path.Split(backSlash);
                newString += parseOfString[0] + "\\\\";
                int n = parseOfString.Length;
                for (int i = 1; i < n; i++)
                    newString += "\\\\" + parseOfString[i];
            }
            return newString;
        }
    }
}
