using System;

namespace e_learning_system
{
    class Subject
    {
        private double grade { set { grade = value; } get { return grade; } }
        private string name { set { name = value; } get { return name; } }
        private string description { set { description = value; } get { return description; } }
        public string getName()
        {
            return this.name;
        }
        public string getDescription()
        {
            return this.description;
        }
        public Subject(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
