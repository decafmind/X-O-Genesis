using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExtension
{
    static class Validation
    {
        public static void limitTextbox(TextBox textbox, string acceptedChar)
        {
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
        }

        public static bool isFilled(Control c)
        {
            foreach (Control cn in c.Controls)
            {
                if (cn is TextBox)
                {
                    TextBox txt = (TextBox)cn;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                        return false;
                }
            }

            return true;
        }
    }


    static class Barcode{

    }

    static class MySqlToCSharp
    {
        public static string convertDateTime(DateTime dateTime)
        {
            return String.Format("{0}-{1}-{2} {3}:{4}:{5}",
                dateTime.Year.ToString(), dateTime.Month.ToString(), dateTime.Day.ToString(),
                dateTime.Hour.ToString(), dateTime.Minute.ToString(), dateTime.Second.ToString());
        }
    }

}
