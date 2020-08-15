using System;

namespace e_learning_system
{
    class SubjectTeacher : TeacherDescriptor
    {
        //TODO : delcare Subject object
        Teacher teacher;
        Subject subject;
        public SubjectTeacher(Subject subject, Teacher teacher)
            :base(teacher)
        {
            // TODO : initialize Subject object
            this.subject = subject;
            this.teacher = teacher;
        }

        public override string getDescription()
        {
            return teacher.getDescription() + "teaches " + subject.getName();
        }
    }
}
