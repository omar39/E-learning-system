using System;
namespace e_learning_system
{
    abstract class TeacherDescriptor : Teacher
    {
        public abstract string getDescription();

        public TeacherDescriptor(Teacher teacher)
            :base(teacher.userID, teacher.name, teacher.phoneNumber, teacher.yearsOfExperience)
        {

        }

    }
}
