using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Layouts.Contracts;
using LoggerLibrary.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Appenders
{
    abstract class Appender : IAppender
    {
        public ReportLevel ReportLevel { get; set; }
        protected ILayout _layout;
        public Appender(ILayout layout)
        {
            this.ReportLevel = ReportLevel.Info;  //leave it or not??
            _layout = layout;
        }
        public abstract void Append(string date, ReportLevel reportLevel, string message);

    }
}
