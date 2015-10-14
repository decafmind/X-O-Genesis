using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PasswordHash;

namespace PetvetPOS_Inventory_System
{
    public class UserMapper: DatabaseMapper
    {
        private const int ACTIVE = 1;
        public UserMapper(MySqlDB db): base(db)
        {
            tableName = "user_tbl";
            id = "id";
            fieldsname = new string[] {
                "id",
                "password",
                "access_level",
                "active",
                "create_time",
                "session_status",
            };
        }


        public List<string> getListOfActiveUsername()
        {
            return getList("id", "active = 1");
        }

        public List<string> getListOfAllUsername()
        {
            return getList("id");
        }

        public string createUser(User user)
        {
            return insertValues(user.UserId, PasswordHash.PasswordHash.CreateHash(user.Password), user.getUserLevel().ToString(), ACTIVE , "NOW()");
        }

        public bool inactivateUser(User user)
        {
            string condition = String.Format("id = '{0}'", user);
            return update(updateSet(condition, "active = 0"));
        }
        public User getUserFromId(string id)
        {
            return new User(getEntityFromId(id));
        }

        public User validate(string user_id, string password)
        {
            List<string> usernames = getListOfActiveUsername();
            if (usernames.Contains(user_id))
            {
                try
                {
                    string condition = String.Format("id = '{0}'", user_id);
                    string correctHash = (string)readScalar("password", condition);
                    bool isValid = PasswordHash.PasswordHash.ValidatePassword(password, correctHash);
                    if (isValid)
                    {
                        condition = String.Format("id = '{0}' AND password = '{1}' AND session_status = 0", user_id, correctHash);
                        return getUserFromId((string)readScalar("id", condition));                      
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        public bool sessionIn(string id)
        {
            string login = String.Format(" session_status = 1");
            string condition = String.Format(" id = '{0}'", id);
            return update(updateSet(condition, login));
        }
        public bool sessionOut(string id)
        {
            string login = String.Format(" session_status = 0");
            string condition = String.Format(" id = '{0}'", id);
            return update(updateSet(login, condition));
        }

 
    }
}
