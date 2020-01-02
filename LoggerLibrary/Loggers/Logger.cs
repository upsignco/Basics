using LoggerLibrary.Loggers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Loggers
{
    //a logger class, which is used to log messages. 
    //Calls each of its appenders when something needs to be logged
    class Logger : ILogger
    {

        public void Critical(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string date, string message)
        {
            throw new NotImplementedException();
        }

        public void Warning(string date, string message)
        {
            throw new NotImplementedException();
        }
    }
}
