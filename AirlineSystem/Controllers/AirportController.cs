using AirlineSystem.Entity;
using AirlineSystem.Entity.ConcreteClasses;
using AirlineSystem.Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;


namespace AirlineSystem.Controllers
{
    class AirportController
    {
        IAirport airport;
        public AirportController()
        {
            //airport = new Airport();  // or aggregation though?
        }
        #region RegisterPassenger

        //If the airport already has a passenger with that username, 
        //throw an InvalidOperationException with the message "Passenger {username} already registered!".
        //The command adds a new passenger into the airport and returns "Registered {passenger.Username}"
        public string RegisterPassenger(string userName)
        {
            IPassenger passenger = airport.GetPassenger(userName);
            if (passenger != null)
                throw new InvalidOperationException($"Passenger {userName} already registered");
            passenger = new Passenger(userName);
            airport.AddPassenger(passenger);
            return $"Registered {passenger.Username}";
        }
        #endregion

        #region RegisterTrip
        //Creates a trip with that source and destination and adds it to the airport.
        //The Id is auto-generated from the Trip class itself.
        //The command returns "Registered trip {tripId}".

        public string RegisterTrip(string source, string destination, IAirplane airplane)
        {
            ITrip trip = new Trip(source, destination, airplane);
            airport.AddTrip(trip);
            string tripId = trip.Id;
            return $"Registered trip {tripId}";
        }
        #endregion

        //Gets a passenger with the provided username from the airport.
        //Then, creates a bag with all the provided items and adds it to the passenger’s bags.
        //The command returns "Registered bag with item1, item2, itemN for {username}"
        public string Registerbag(string userName,IEnumerable<IItem> bagItems)
        {
            IPassenger passenger = airport.GetPassenger(userName);
            IBag bag = new Bag(passenger, bagItems);
            passenger.Bags.Add(bag);
            string message="Registered bag with ";
            IEnumerator<IItem> iterator = bagItems.GetEnumerator();
            while (iterator.MoveNext())
            {
                message += iterator.Current.ToString(); 
            }
            return message;
            //should be fixed output message with ,
        }
    }
}
