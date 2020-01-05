using LoggerLibrary.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Layouts
{
    class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            switch (type)
            {
                case "SimpleLayout":
                    return new SimpleLayout();
                case "XmlLayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("There is no such Layout");
                    break;
            }
        }
    }
}
