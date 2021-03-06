﻿using System.Collections.Generic;

namespace e_learning_system
{
    class Classroom
    {
        private int id;
        private Subject subject;
        private List<Student> students = new List<Student>();
        // hena el teachers variable
        public Classroom(int id1 , Subject subj)
        {
            this.id = id1;
            this.subject = subj;
            //this.students = students1;
        }

        public Subject getSubject()
        {
            return this.subject;
        }
        public int get_id()
        {
            return this.id;
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
