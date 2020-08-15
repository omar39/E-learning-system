using System;

namespace e_learning_system
{
    class ClassTeacher : Teacher
    {
        // TODO: declare classroom object
        Classroom classroom;
        public ClassTeacher(int userID, string name, string phoneNumber, int yearsOfExperience, Classroom classroom)
            :base(userID,name, phoneNumber, yearsOfExperience )
        {
            //classroom 
            this.classroom = classroom;
        }
        public override string getDescription()
        {
            return "supervises class " + classroom.getName();
        }
        public Classroom getClassroom()
        {
            return classroom;
        }
    }
}
