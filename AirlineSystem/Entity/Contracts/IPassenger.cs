using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineSystem.Entity.Contracts
{
    interface IPassenger
    {
        string Username { get; }

        IList<IBag> Bags { get; }
    }
}
