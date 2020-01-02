using AirlineSystem.Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineSystem.Entity.ConcreteClasses
{
    class Passenger : IPassenger
    {
        private string _userName;
        public Passenger(string userName)
        {

        }
        public string Username => _userName;
        public IList<IBag> Bags => throw new NotImplementedException();
    }
}
