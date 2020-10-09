using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    abstract class CommonDriver : Person
    {
        private Passenger passenger;
    
        public CommonDriver(string name, string lastname, string id, string photo, string bio, string vehicle) 
        : base(name, lastname, id, photo){}

         public void AddPassenger(Passenger pas)
        {
            if(this.passenger == null)
            {
                this.passenger = pas;
            }
            else
            {
                this.RemovePassenger(passenger);
                this.AddPassenger(pas);
            }
        }

        public void RemovePassenger(Passenger pas)
        {
            this.passenger = null;
        }

    }
}
