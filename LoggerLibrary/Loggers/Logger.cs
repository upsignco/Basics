using LoggerLibrary.Appenders.Contracts;
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
        private IAppender _appender;
        public Logger(IAppender appender)
        {
            this._appender = appender;
        }
        public void Critical(string date, string message)
        {
            AppendMessage(date, ReportLevel.Critical, message);
        }

        public void Error(string date, string message)
        {
            AppendMessage(date, ReportLevel.Error, message);
        }

        public void Fatal(string date, string message)
        {
            AppendMessage(date, ReportLevel.Fatal, message);
        }

        public void Info(string date, string message)
        {
            AppendMessage(date, ReportLevel.Info, message);
        }

        public void Warning(string date, string message)
        {
            AppendMessage(date, ReportLevel.Warning, message);
        }

        private void AppendMessage(string date, ReportLevel reportLevel, string message)
        {
            _appender.Append(date, reportLevel, message);
        }

    }
    public enum ReportLevel
    {
        Info,
        Warning,
        Error,
        Critical,
        Fatal
    }
}
