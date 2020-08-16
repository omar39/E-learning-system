using System;

namespace e_learning_system
{
     class Teacher : User, ITeacher
    {
        protected string description;
        public int yearsOfExperience { set { this.yearsOfExperience = value; } get { return yearsOfExperience; } }

        public Teacher(string name, string phoneNumber,  int yearsOfExperience)
        :base(name, phoneNumber)
        {
            this.yearsOfExperience = yearsOfExperience;
        }
        public Teacher(string name, string phoneNumber) 
            : base(name, phoneNumber)
        {
   
        }
        public Teacher() { }
        public override bool signIn()
        {
            throw new NotImplementedException();
        }
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
