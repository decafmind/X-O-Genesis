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
                    {
                        return false;
                    }
                }
                else if (cn is ComboBox)
                {
                    ComboBox cb = (ComboBox)cn;
                    if (string.IsNullOrWhiteSpace(cb.Text))
                        return false;
                }
            }

            return true;
        }

        public static void clearFields(Control c)
        {
            foreach (Control cn in c.Controls)
            {
                if (cn is TextBox)
                {
                    TextBox txt = (TextBox)cn;
                    txt.Clear();
                }
                else if (cn is ComboBox)
                {
                    ComboBox cb = (ComboBox)cn;
                    cb.Items.Clear();
                }
            }

        }

        public static void filterToContactNo(TextBox textbox)
        {
            string acceptedChar = "+1234567890";
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
        }
        public static void filterToNumeric(TextBox textbox)
        {
            string acceptedChar = "1234567890";
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
        }
        public static void filterToAplha(TextBox textbox)
        {
            string acceptedChar = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
        }
        public static void filterToAlphaNumeric(TextBox textbox)
        {
            string acceptedChar = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
        }
        public static void filterToParagraph(TextBox textbox)
        {
            string acceptedChar = ".,abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 ";
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
        }
        public static void filterToEmail(TextBox textbox)
        {
            string acceptedChar = ".abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@_";
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
        }
        public static void filterToNames(TextBox textbox)
        {
            string acceptedChar = ".abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            string result = "";
            foreach (char character in textbox.Text)
                if (acceptedChar.Contains(character))
                    result += character;
            textbox.Text = result;
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
