using System;

namespace e_learning_system
{
    class ClassTeacher : TeacherDescriptor
    {
        // TODO: declare classroom object
        Classroom classroom;
        public ClassTeacher(Classroom classroom, Teacher teacher):
            base(teacher)
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
