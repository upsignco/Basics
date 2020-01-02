using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineSystem.Entity.Contracts
{
    interface ITrip
    {
		string Id { get; }

		string Source { get; }

		string Destination { get; }

		bool IsCompleted { get; }

		IAirplane Airplane { get; }

		void Complete();
	}
}
