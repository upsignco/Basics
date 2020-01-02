﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineSystem.Entity.Contracts
{
    interface IAirport
    {
		IReadOnlyCollection<IBag> CheckedInBags { get; }

		IReadOnlyCollection<IBag> ConfiscatedBags { get; }

		IReadOnlyCollection<IPassenger> Passengers { get; }

		IReadOnlyCollection<ITrip> Trips { get; }

		void AddPassenger(IPassenger passenger);

		void AddCheckedBag(IBag bag);

		void AddConfiscatedBag(IBag bag);

		void AddTrip(ITrip trip);

		IPassenger GetPassenger(string username);

		ITrip GetTrip(string id);
	}
}
