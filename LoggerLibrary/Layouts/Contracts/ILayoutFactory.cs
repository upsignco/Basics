using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Layouts.Contracts
{
    interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
