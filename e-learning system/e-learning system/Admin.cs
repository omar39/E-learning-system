using System;

namespace e_learning_system
{
    class Admin : User
    {
        private Admin instance;
        private Admin(int userID, string name, string phoneNumber):base(userID, name, phoneNumber)
        {
            
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
        public Admin getInstance(int userID, string name, string phoneNumber)
        {
            return instance == null ? instance = new Admin(userID, name, phoneNumber) : null;
        }
    }
}
