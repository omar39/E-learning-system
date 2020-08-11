using System;

namespace e_learning_system
{
    class SubjectTeacher : Teacher
    {
        //TODO : delcare Subject object
        public SubjectTeacher(int userID, string name, string phoneNumber, int yearsOfExperience)
            :base(userID, name, phoneNumber, yearsOfExperience)
        {
            // TODO : initialize Subject object
        }
        public override string getDescription()
        {
            throw new NotImplementedException();
        }
    }
}
