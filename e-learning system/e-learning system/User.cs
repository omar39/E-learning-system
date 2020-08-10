using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_learning_system
{
    abstract class User
    {
        protected string name { set; get; }
        protected string phoneNumber { set; get; }
        protected int userID { set; get; }

        public int getUserID()
        {
            return userID;
        }
        public string getName()
        {
            return name;
        }
        public string getPhoneNumber()
        {
            return phoneNumber;
        }
        public abstract bool signIn();
    }
}
