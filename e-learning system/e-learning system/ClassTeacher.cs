using System;

namespace e_learning_system
{
    class ClassTeacher : ITeacher
    {
        // TODO: declare classroom object
        Classroom classroom;
        ITeacher _teacher;
        public ClassTeacher(Classroom classroom, ITeacher teacher)
        {
            //classroom 
            this.classroom = classroom;
            _teacher = teacher;
        }
        public string getDescription()
        {
            return _teacher.getDescription() + "supervises class " + classroom.getName();
        }
        public Classroom getClassroom()
        {
            return classroom;
        }

    }

}
