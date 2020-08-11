using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_learning_system
{
    class Classroom
    {
        private String name;
        readonly int originalCapacity = 30;
        private Subject subject;
        private List<Student> students = new List<Student>();
        // hena el teachers variable
        public Classroom(String name1 , Subject subj , List<Student> students1)
        {
            this.name = name1;
            this.subject = subj;
            this.students = students1;
        }
        public string getName()
        {
            return this.name;
        }
        public Subject getSubject()
        {
            return this.subject;
        }

        public int calculateCapacity()
        {
            return originalCapacity - students.Count;
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }
        public void removeStudent(Student student)
        {
            students.Remove(student);
        }
    }
}
