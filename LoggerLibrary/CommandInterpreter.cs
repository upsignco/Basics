using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Loggers.Contracts;
using LoggerLibrary.Loggers;
using System;
using System.Collections.Generic;
using System.Text;
using LoggerLibrary.Appenders;
using LoggerLibrary.Layouts.Contracts;
using LoggerLibrary.Layouts;

namespace LoggerLibrary
{
    class CommandInterpreter : ICommandInterpreter
    {
        ICollection<IAppender> _appenders;
        IAppenderFactory _appenderFactory;
        ILayoutFactory _layoutFactory;
        public CommandInterpreter()
        {
            _appenders = new List<IAppender>();
            _layoutFactory = new LayoutFactory();
            _appenderFactory = new AppenderFactory();
        }
        public void AddAppender(string[] appenderConfig) // "<appender type> <layout type> <REPORT LEVEL>"
        {
            string appenderType = appenderConfig[0];
            string layoutType = appenderConfig[1];
            ILayout layout = _layoutFactory.CreateLayout(layoutType);
            IAppender appender = _appenderFactory.CreateAppender(appenderType, layout);
            if (appenderConfig.Length == 3)
            { appender.ReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), appenderConfig[3]); }  //fix that
            else
            { appender.ReportLevel = ReportLevel.Info; }
            _appenders.Add(appender);
        }

        public void AddMessage(string[] messageArgs) // "<REPORT LEVEL>|<time>|<message>"
        {
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(messageArgs[0]);
            string date = messageArgs[1];
            string message = messageArgs[2];
            foreach (var appender in _appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }
    }
}
