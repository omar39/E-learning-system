using System;

namespace e_learning_system
{
    abstract class Teacher : User
    {
        protected string description;
        protected int yearsOfExperience { set { this.yearsOfExperience = value; } get { return yearsOfExperience; } }

        public Teacher(int userID, string name, string phoneNumber,  int yearsOfExperience):base(userID, name, phoneNumber)
        {
            this.yearsOfExperience = yearsOfExperience;
        }
        public abstract string getDescription();
        public override bool signIn()
        {
            throw new NotImplementedException();
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}
