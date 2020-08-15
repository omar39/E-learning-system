using System;

namespace e_learning_system
{
    class SubjectTeacher : Teacher
    {
        //TODO : delcare Subject object
        Subject subject;
        public SubjectTeacher(int userID, string name, string phoneNumber, int yearsOfExperience, Subject subject)
            :base(userID, name, phoneNumber, yearsOfExperience)
        {
            // TODO : initialize Subject object
            this.subject = subject;
        }
        public override string getDescription()
        {
            return "teaches " + subject.getName();
        }
    }
}
