using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PetvetPOS_Inventory_System
{
    // TODO
    // Model Class

    [Serializable]
    public class User: IEntity, IDisposable
    {
        // Login details
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool Session { get; set; }
        private UserLevel _UserLevel;
        public int Squery { get; set; }
        public string FBAnswer { get; set; }

        public User()
        {

        }   

        public User(Entity entity)
        {
            this.UserId = (string)entity.getField("id");
            this.Password = (string)entity.getField("password");
            this.userLevel = (string)entity.getField("access_level");
            //this.Session = (bool)entity.getField("session_status");
            this.FBAnswer = (string)entity.getField("fallbackans");
            this.Squery = (int)entity.getField("fallbackid");  
        }

        public User(string user_id, string password, string user_level)
        {
            this.UserId = user_id;
            this.Password = password;
            this.userLevel = user_level;
        }

        public UserLevel getUserLevel()
        {
            return _UserLevel;
        }

        public string userLevel 
        {
            set
            {
                if (value.ToUpper() == "ADMIN")
                {
                    _UserLevel = UserLevel.ADMIN;
                }
                else if (value.ToUpper() == "CASHIER")
                {
                    _UserLevel = UserLevel.CASHIER;
                }
                else if (value.ToUpper() == "STAFF")
                {
                    _UserLevel = UserLevel.STAFF;
                }
                else
                {
                    _UserLevel = UserLevel.INVENTORY_PERSONNEL;
                }
                
            }
        }

        public bool checkPasswordIfValid(string password)
        {
            if (this.Password == password)
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            User usr = obj as User;

            if (usr != null)
                if(usr.UserId == this.UserId)
                  return true;
            
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return UserId;
        }

        public void Dispose()
        {

        }
    }
}
