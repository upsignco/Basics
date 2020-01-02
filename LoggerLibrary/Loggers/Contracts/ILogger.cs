using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Loggers.Contracts
{
    //hold methods for various kinds of logging(warnings, errors, info, etc.)
    interface ILogger
    {
        void Info(string date, string message);
        void Warning(string date, string message);
        void Error(string date, string message);
        void Critical(string date, string message);
        void Fatal(string date, string message);
    }
}
