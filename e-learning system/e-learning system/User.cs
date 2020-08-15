using System;

namespace e_learning_system
{
    abstract class User
    {
        public string name { set { this.name = value; } get {return name; } }
        public string phoneNumber { set {this.phoneNumber=value; } get {return phoneNumber; } }
        public int userID { set { this.userID = value; } get { return userID; } }

        public User() { }
        public User(int userID, string name, string phoneNumber)
        {
            this.userID = userID;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public abstract bool signIn();
    }
}
