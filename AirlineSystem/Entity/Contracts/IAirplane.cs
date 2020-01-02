using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineSystem.Entity.Contracts
{
    interface IAirplane
    {
		int Seats { get; }
		int BaggageCompartments { get; }
		IReadOnlyCollection<IPassenger> Passengers { get; }
		IReadOnlyCollection<IBag> BaggageCompartment { get; }
		bool IsOverbooked { get; }
		void AddPassenger(IPassenger passenger);
		IPassenger RemovePassenger(int seat);
		IEnumerable<IBag> EjectPassengerBags(IPassenger passenger);
		void LoadBag(IBag bag);
	}
}
