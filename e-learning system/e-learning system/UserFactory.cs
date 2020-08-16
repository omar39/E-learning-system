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

            if (type == "Teacher")
                return new Teacher(name, phoneNumber);
            else if (type == "Student")
                return new Student(name, phoneNumber);
            else if (type == "Admin")
                return Admin.getInstance(name, phoneNumber);
            else return null;
     
        }
    }
}
