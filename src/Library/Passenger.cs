using System;
using System.Collections;

namespace PII_Herencia
{
    abstract class Passenger : Person
    {
        private string bio;
        private string vehicle;
        private Driver myDriver;

        public Passenger(string name, string lastname, string id, string photo) : base(name, lastname, id, photo){}

        public override void RateUser(Person user, int rating)
        {
            user.Grade = user.Grade + rating;
        }

        public void JoinDriver(Driver driver)
        {
            if(this.myDriver == null)
            {
                this.myDriver = driver;
            }
            else
            {
                this.DisposeDriver(myDriver);
                this.JoinDriver(driver);
            }
        }

        public void DisposeDriver(Driver driver)
        {
            this.myDriver = null;
        }
    }
}
