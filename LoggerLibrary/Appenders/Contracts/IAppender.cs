using LoggerLibrary.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Appenders.Contracts
{
    //responsible for appending the messages somewhere 
    interface IAppender
    {
        ReportLevel ReportLevel { get; set; }
        void Append(string date, ReportLevel reportLevel, string message);
    }
}
