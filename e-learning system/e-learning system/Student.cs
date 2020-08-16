﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_learning_system
{
    class Student : User
    {
        Classroom current_class;
        List<Tuple<Subject, double>> grades = new List<Tuple<Subject, double>>();
        List<string> comments = new List<string>();
        public override bool signIn()
        {
            return true;
        }
        public Student() { }
        Student(int userId, string name, string phoneNumber):base(userId,name ,phoneNumber)
        {

        }
        public bool registerToClass(Classroom class1)
        {
            if (class1.calculateCapacity() > 0)
            {
                class1.addStudent(this);
                this.current_class = class1;
                return true;
            }
            else return false;

        }
        public Classroom GetClassroom()
        {
            return this.current_class;
        }
        public bool changeClassRoom(Classroom class1)
        {
            if (class1.calculateCapacity() > 0)
            {
                this.current_class.removeStudent(this);
                class1.addStudent(this);
                this.current_class = class1;
                return true;
            }
            else return false;
        }
        public double calculateGrade()
        {
            int num_of_subjects = this.grades.Count;
            double sum_of_grades = 0;
            foreach(Tuple<Subject,double> x in grades)
            {
                sum_of_grades += x.Item2;
            }
            double final_grade = sum_of_grades / num_of_subjects;
            return final_grade;
        }
        public void enroll(Subject subject)
        {
            Tuple<Subject, double> tmp= new Tuple<Subject, double>(subject,0);
            grades.Add(tmp);
        }
        public void addComment(string comment)
        {
            comments.Add(comment);
        }
        
    }
}
