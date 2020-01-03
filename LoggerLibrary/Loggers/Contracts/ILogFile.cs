using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Loggers.Contracts
{
    interface ILogFile
    {
        void Write(string message);
    }
}
