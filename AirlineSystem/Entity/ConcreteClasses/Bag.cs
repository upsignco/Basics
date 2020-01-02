using AirlineSystem.Entity.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AirlineSystem.Entity.ConcreteClasses
{
    class Bag : IBag
    {
        IPassenger _passenger;
        List<IItem> _bagItems;
        public Bag(IPassenger passenger, IEnumerable<IItem> bagItems)
        {
            this._passenger = passenger;
            this._bagItems = bagItems.ToList();
        }
        public IPassenger Owner => _passenger;

        public IReadOnlyCollection<IItem> Items => _bagItems.AsReadOnly();
    }
}
