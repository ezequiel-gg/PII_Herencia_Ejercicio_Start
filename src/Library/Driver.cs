using System;
using System.Collections;

namespace PII_Herencia
{
    abstract class Driver : Person
    {
        private string bio;
        private string vehicle;

        public Driver(string name, string lastname, string id, string photo, string bio, string vehicle) 
        : base(name, lastname, id, photo)
        {
            this.bio = bio;
            this.vehicle = vehicle;
        }

        public override void RateUser(Person user, int rating)
        {
            user.Grade = user.Grade + rating;
        }

        public abstract void AddPassenger(Passenger pas);

    }
}
