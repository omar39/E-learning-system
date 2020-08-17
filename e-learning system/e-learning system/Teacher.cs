using System;

namespace e_learning_system
{
     class Teacher : User, ITeacher
    {
        protected string description;
        public int yearsOfExperience { set { this.yearsOfExperience = value; } get { return yearsOfExperience; } }

        public Teacher(string name, string phoneNumber,  int yearsOfExperience,int id)
        :base(name, phoneNumber,id)
        {
            this.yearsOfExperience = yearsOfExperience;
        }
        public Teacher(string name, string phoneNumber,int id) 
            : base(name, phoneNumber,id)
        {
   
        }
        public Teacher() { }
        
        public void setDescription(string description)
        {
            this.description = description;
        }
        public string getDescription()
        {
            return description;
        }
    }

}
