using System;

namespace e_learning_system
{
    class Subject
    {
        private double grade;
        private string name;
        private string description;
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
