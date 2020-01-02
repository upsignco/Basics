using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineSystem.Entity.Contracts
{
    interface IBag
    {
        IPassenger Owner { get; }
        IReadOnlyCollection<IItem> Items { get; }
    }
}
