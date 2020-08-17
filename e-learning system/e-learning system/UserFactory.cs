using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_learning_system
{
    class UserFactory
    {
        public static User make_user(string type, string name, string phoneNumber)
        {

            if (type == "teacher")
                return new Teacher(name, phoneNumber);
            else if (type == "student")
                return new Student(name, phoneNumber);
            else if (type == "admin")
                return Admin.getInstance(name, phoneNumber);
            else return null;
     
        }
    }
}
