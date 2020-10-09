using System;
using System.Collections;

namespace PII_Herencia
{
    public abstract class Person
    {
        protected string name;
        protected string lastName;
        protected string id;
        protected int grade;
        protected string photoPath;

        public Person(string name, string lastname, string id, string photo)
        {
            this.name = name;
            this.lastName = lastname;
            this.id = id;
            this.photoPath = photo;
        }

        public int Grade
        {
            get 
            {
                return this.grade;
            }
            set
            {
                if(value > 0)
                {
                    this.grade = value;
                }
            }
        }

        public abstract void RateUser(Person user, int rating);

    }
}
