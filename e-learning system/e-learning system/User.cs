using System;

namespace e_learning_system
{
    abstract class User
    {
        public string name;//{ set { this.name = value; } get {return name; } }
        public string phoneNumber;// { set {this.phoneNumber=value; } get {return phoneNumber; } }

        public User() { }
        public User(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        
    }
}
