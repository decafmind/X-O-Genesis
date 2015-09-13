using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    public class ErrorLog
    {
        private static string FILENAME = "error.log";

        public static void Log(Exception e){
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Petvet\Log\";
           
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            using (StreamWriter writer = new StreamWriter(directory + FILENAME, true))
            {
                string log_message = string.Format("{0} -- {1} from {2}", DateTime.Now.ToLongDateString(), e.Message, e.Source);
                writer.WriteLine(log_message);
                writer.WriteLine(e.StackTrace);
            }
        }
    }
}
