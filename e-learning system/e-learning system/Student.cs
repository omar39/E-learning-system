using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_learning_system
{
    class Student : User
    {
        List<Classroom> studentClasses = new List<Classroom>();
        List<double> grades = new List<double>();
        List<Subject> subjects = new List<Subject>();
        

        List<string> comments = new List<string>();
        public override bool signIn()
        {
            return true;
        }
        public Student() { }
        public Student(string name, string phoneNumber)
            :base(name ,phoneNumber)
        {
        }
        public bool registerToClass(Classroom class1)
        {
            if (class1.calculateCapacity() > 0)
            {
                class1.addStudent(this);
                this.studentClasses.Add(class1);
                this.grades.Add(0);
                this.subjects.Add(class1.getSubject());
                return true;
            }
            else return false;

        }
        public List<Classroom> GetClassrooms()
        {
            return this.studentClasses;
        }
        public bool changeClassRoom(Classroom class1)
        {
            if (class1.calculateCapacity() > 0)
            {
                for(int x=0;x<studentClasses.Count;x++ )
                {
                    if(studentClasses[x].getSubject() == class1.getSubject())
                    {
                        studentClasses[x].removeStudent(this);
                        studentClasses.RemoveAt(x);
                    }
                }
                
                class1.addStudent(this);
                studentClasses.Add(class1);
                return true;
            }
            else return false;
        }
        public double calculateGrade()
        {
            int num_of_subjects = this.grades.Count;
            double sum_of_grades = 0;
            foreach(double x in grades)
            {
                sum_of_grades += x;
            }
            double final_grade = sum_of_grades / num_of_subjects;
            return final_grade;
        }
      
        public void set_grade(string subjectName , double grade)
        {

            for (int x = 0; x < this.grades.Count; x++)
            {
                if (this.subjects[x].getName().Equals(subjectName))
                {
                    this.grades[x] = grade;
                    
                }
            }
        }

        public void addComment(string comment)
        {
            comments.Add(comment);
        }
        
    }
}
