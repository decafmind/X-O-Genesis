using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PetvetPOS_Inventory_System
{   
    public partial class BackUpControl : MyUserControl, IContentPage
    {

        MySqlDB mysqldb;
        private string constring;

        private const int BACKUP = 1;
        private const int RESTORE = 2;

        public BackUpControl()
        {
            InitializeComponent();
        }

        public BackUpControl(MasterController masterController, MySqlDB mysqlDb)
            : base(masterController)
        {
            this.dbController = masterController.DataBaseController;
            this.mysqldb = mysqlDb;
            this.constring = "server=" + mysqldb.Host + ";user=" + mysqldb.User_id + ";pwd="
                    + mysqldb.Password + ";database=" + mysqldb.Database + ";";
            InitializeComponent();
        }
 
        public void initializePage()
        {
 	        
        }

        public void finalizePage()
        {
 	       
        }

        public Menu accessMenuName
        {
            get { return Menu.Backup_Restore; }
        }

        public Bitmap accessImage
        {
            get { return Properties.Resources.Export; }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            browseFolderPath(txtPath, BACKUP);
        }
        void browseFolderPath(TextBox holder, int action)
        {
            switch (action)
            {
                case BACKUP:
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    DialogResult result = fbd.ShowDialog();
                    if (result != DialogResult.Cancel)
                    {
                        string path = fbd.SelectedPath;
                        holder.Text = path;
                    }
                    break;

                case RESTORE:
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Multiselect = false;
                    DialogResult res = ofd.ShowDialog();
                    if (res != DialogResult.Cancel)
                    {
                        string path = ofd.FileName;
                        holder.Text = path;
                    }
                    break;

                default:
                    MessageBox.Show("Invalid action.");
                    break;
            }
            
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            backupRestore(txtPath.Text, BACKUP);
        }

        void backupRestore(string path, int action)
        {
            if (!string.IsNullOrWhiteSpace(path))
            {             
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            try
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                switch (action)
                                {
                                    case BACKUP:
                                        string dateTime = DateTime.Now.ToShortDateString().Replace("/", "");
                                        string fileName = "Dump" + dateTime + "_" + Guid.NewGuid() + ".sql";
                                        string fpath = path + "/" + fileName;

                                        mb.ExportToFile(fpath);
                                        MessageBox.Show("Backup successful.");
                                        break;

                                    case RESTORE:
                                        mb.ImportFromFile(path);
                                        MessageBox.Show("Restore successful.");
                                        break;
                                }

                            }
                            catch (Exception ex)
                            {
                                switch (action)
                                {
                                    case BACKUP:
                                        MessageBox.Show("Failed to backup db. ");
                                        ErrorLog.Log(ex);
                                        break;

                                    case RESTORE:
                                        MessageBox.Show("Failed to restore db. ");
                                        ErrorLog.Log(ex);
                                        break;

                                    default:
                                        MessageBox.Show("Invalid action.");
                                        break;
                                }

                            }
                            finally
                            {
                                conn.Close();
                                conn.Dispose();
                                cmd.Dispose();
                                mb.Dispose();
                            }
                        }
                    }
                }
                txtPath.Text = string.Empty;
                txtSelected.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select a directory to continue.");
                switch (action)
                {
                    case BACKUP:
                        browseFolderPath(txtPath, BACKUP);
                        break;

                    case RESTORE:
                        browseFolderPath(txtSelected, RESTORE);
                        break;

                    default:
                        MessageBox.Show("Invalid action.");
                        break;
                }
                
            }
        }
     
        private void btnSelect_Click(object sender, EventArgs e)
        {
            browseFolderPath(txtSelected, RESTORE);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            backupRestore(txtSelected.Text, RESTORE);
        }
    }
}
