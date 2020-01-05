using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Layouts.Contracts;
using LoggerLibrary.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Appenders
{
    class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            switch (type)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout);
                case "FileAppender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("There is no such appender");
            }
        }
    }
}
