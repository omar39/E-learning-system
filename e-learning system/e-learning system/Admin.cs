using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_learning_system
{
    class Admin : User
    {
        private Admin(int userID, string name, string phoneNumber)
        {
            this.userID = userID;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public override bool signIn()
        {
            //
            return true;
        }
        public bool removeUser(int userID)
        {
            return true;
        }
        public bool approveUser(User user)
        {
            return true;
        }
    }
}
