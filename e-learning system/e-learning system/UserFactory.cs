using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_learning_system
{
    class UserFactory
    {
        public User make_user(string type)
        {
          
            if (type == "teacher")
                return new Teacher();
            else if (type == "student")
                return new Student();
            else return null;
     
        }
    }
}
