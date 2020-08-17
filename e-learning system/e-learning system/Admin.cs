using System;

namespace e_learning_system
{
    class Admin : User
    {
        private static Admin instance;
        private Admin(string name, string phoneNumber,int id)
            :base(name, phoneNumber, id)
        {
            
        }

        public bool removeUser(int userID)
        {
            return true;
        }
        public bool approveUser(User user)
        {
            return true;
        }
        public static Admin getInstance(string name, string phoneNumber,int id)
        {
            return instance == null ? instance = new Admin(name, phoneNumber,id) : null;
        }
    }
}
