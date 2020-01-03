using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Layouts.Contracts;
using LoggerLibrary.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Appenders
{
    //appends a log to the console, using the provided layout
    class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }
        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel >= reportLevel)
            {
                string outputMessage = string.Format(this._layout.Format, date, reportLevel, message);
                Console.WriteLine(outputMessage);
            }
        }
    }
}
