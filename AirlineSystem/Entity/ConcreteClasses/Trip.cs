using AirlineSystem.Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineSystem.Entity.ConcreteClasses
{
    class Trip : ITrip
    {
        private static int counter = 0;
        private string _id;
        private string _source;
        private string _destination;
        private IAirplane _airplane;
        public Trip(string source, string destination, IAirplane airplane)  
        {
            counter++;
            _id = source + destination + counter;
            this._source = source;
            this._destination = destination;
            this._airplane = airplane;
        }
        public string Id => _id;

        public string Source => _source;

        public string Destination => _destination;

        public bool IsCompleted => throw new NotImplementedException();

        public IAirplane Airplane => _airplane;

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
