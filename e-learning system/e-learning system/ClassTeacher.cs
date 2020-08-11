using System;

namespace e_learning_system
{
    class ClassTeacher : Teacher
    {
        // TODO: declare classroom object
        public ClassTeacher(int userID, string name, string phoneNumber, int yearsOfExperience)
            :base(userID,name, phoneNumber, yearsOfExperience )
        {
            //classroom 
        }
        public override string getDescription()
        {
            throw new NotImplementedException();
        }
    }
}
