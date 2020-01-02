using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Layouts.Contracts
{
    //define the format in which messages should be appended 
    interface ILayout
    {
        string Format { get; }
    }
}
