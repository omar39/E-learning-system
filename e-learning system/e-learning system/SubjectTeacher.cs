using System;

namespace e_learning_system
{
    class SubjectTeacher : ITeacher
    {
        //TODO : delcare Subject object
        Subject subject;
        ITeacher _teacher;
        public SubjectTeacher(Subject subject, ITeacher teacher)
        {
            // TODO : initialize Subject object
            this.subject = subject;
            _teacher = teacher;
        }

        public  string getDescription()
        {
            return _teacher.getDescription() + "teaches " + subject.getName();
        }
    }
}
