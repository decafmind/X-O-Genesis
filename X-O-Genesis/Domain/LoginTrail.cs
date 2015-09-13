using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetvetPOS_Inventory_System
{
    [Serializable]
    public class LoginTrail: IEntity
    {
        User currentUser;
        DateTime loginDateTime;
        DateTime logoutDateTime;

        public string Username { get { return currentUser.UserId; } }
        public DateTime LoginDateTime { get { return loginDateTime; } }
        public DateTime LogoutDateTime { get { return logoutDateTime; } }
        public User User { get { return currentUser; } }

      //  MasterController masterController;
 
        public LoginTrail(User user)
        {
            this.currentUser = user;
        }

        public void timeOn()
        {
            loginDateTime = DateTime.Now;
        }

        //public void timeOff(LoginTrail loginTrail)
        //{
        //    loginTrail.timeOff();
        //}

        public void timeOff()
        {
            logoutDateTime = DateTime.Now;
        }

    }
}
