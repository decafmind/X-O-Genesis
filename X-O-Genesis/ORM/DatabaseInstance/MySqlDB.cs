using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace PetvetPOS_Inventory_System
{
    public class MySqlDB: IDisposable
    {
        public string Host { get; set; }
        public string User_id { get; set; }
        public string Password { get; set; }
        public string Database { get; private set; }

        public MySqlConnection Connection { get; private set; }
        DatabaseSettings dbSettings;

        /* Default values for MySql Database*/
        private const string DEFAULT_DATABASE = "pos_inventory_db";

        public MySqlDB()
        {
            Database = DEFAULT_DATABASE;

            string mydocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = mydocuments + @"\Petvet\Database\connection";

            if (File.Exists(filepath))
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    Host = sr.ReadLine();
                    User_id = sr.ReadLine();
                    Password = sr.ReadLine();
                }
            }
            else
            {
                dbSettings = new DatabaseSettings(this);
                dbSettings.ShowDialog();
            }
       }

        public MySqlDB(string host, string user_id, string password)
        {
            Host = host;
            User_id = user_id;
            Password = password;
            Database = DEFAULT_DATABASE;
        }

        public void open()
        {
            try
            {
                string connectionString = String.Format("host = '{0}'; user = '{1}'; password = '{2}'; database = '{3}'", Host, User_id, Password, Database);
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }
            catch (MySqlException mex)
            {
                MessageBox.Show("It seems that the Database Autentication was not properly configured", "Fix it");
                if (dbSettings == null)
                {
                    dbSettings = new DatabaseSettings(this);
           //         dbSettings.button1.Click += button1_Click;
                    dbSettings.ShowDialog();
                }
                ErrorLog.Log(mex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);   
            }
        }

        //void button1_Click(object sender, EventArgs e)
        //{
        //    open();
        //}

        public void close()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                try{
                    Connection.Close();
                }
                catch (MySqlException mx){
                    ErrorLog.Log(mx);
                }
                catch (Exception ex){
                    ErrorLog.Log(ex);
                }
            }

        }

        public void dispose()
        {
            Connection.Close();
            Connection.Dispose();
        }

        public void Dispose()
        {
            dispose();
        }        
        

    }
}
