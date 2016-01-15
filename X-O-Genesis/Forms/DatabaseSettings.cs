using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListNetworkComputerNames;

namespace PetvetPOS_Inventory_System
{
    public partial class DatabaseSettings : Form
    {
        MySqlDB mySqlDb;

        // Drop shadow
        private const int CS_DROPSHADOW = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public DatabaseSettings()
        {
            InitializeComponent();
        }

        public DatabaseSettings(MySqlDB db)
        {
            InitializeComponent();
            this.mySqlDb = db;

            try
            {
                NetworkBrowser nb = new NetworkBrowser();
                foreach (string pc in nb.getNetworkComputers()){
                    cmbHost.Items.Add(pc);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred trying to access the network computers", "error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        protected bool testConnection()
        {
            bool connectionSucceed = false;
            try
            {
                mySqlDb.open();
                if (mySqlDb.Connection.State == ConnectionState.Open)
                    connectionSucceed = true;
            }
            catch(MySql.Data.MySqlClient.MySqlException mEx)
            {
                ErrorLog.Log(mEx);
            }
            finally
            {
                mySqlDb.dispose();
            }

            return connectionSucceed;
        }

        private void button1_Click(object sender, EventArgs e){
           
            mySqlDb.Host = cmbHost.Text;
            mySqlDb.User_id = txtUser.Text;
            mySqlDb.Password = txtPassword.Text;

            if (testConnection() == true)
            {
                string local = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string directory = local + @"\Exogenesis\Database\";
                string filepath = @"connection";

                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter sw = new StreamWriter(directory + filepath, false))
                {
                    sw.WriteLine(mySqlDb.Host);
                    sw.WriteLine(mySqlDb.User_id);
                    sw.WriteLine(mySqlDb.Password);
                }

                MessageBox.Show("Connection succeed");
                mySqlDb.grantAllAccessToOtherHost();
                Close();
            }
            else
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void DatabaseSettings_Load(object sender, EventArgs e)
        {
            cmbHost.Text = "localhost";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(cmbHost.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text)))
            {
                Close();
            }
            else
            {

            }
        }
    }
}
