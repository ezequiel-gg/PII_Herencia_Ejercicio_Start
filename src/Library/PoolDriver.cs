using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    abstract class PoolDriver : Person
    {
        private List<Passenger> passengers;
        private int maxCapacity;    
        public PoolDriver(string name, string lastname, string id, string photo, string bio, string vehicle) 
        : base(name, lastname, id, photo){}

        public void AddPassenger(Passenger pas)
        {
            if(!this.passengers.Contains(pas) & (this.passengers.Count < this.maxCapacity))
            {
                this.passengers.Add(pas);
            }
        }
        public void RemovePassenger(Passenger pas)
        {
            if(this.passengers.Contains(pas))
            {
                this.passengers.Remove(pas);
            }
        }

    }
}
