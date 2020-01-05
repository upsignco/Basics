using LoggerLibrary.Layouts.Contracts;
using LoggerLibrary.Loggers;
using LoggerLibrary.Loggers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoggerLibrary.Appenders
{
    //appends a log to a file, using the provided layout
    class FileAppender : Appender
    {
        const string _path = "log.txt";
        ILogFile _logFile;
        public FileAppender(ILayout layout, ILogFile logFile) : base(layout)
        {
            this._logFile = logFile;
        }
        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel >= reportLevel)
            {
                string outputMessage = string.Format(this._layout.Format, date, reportLevel, message) + "\n";
                _logFile.Write(outputMessage);
                File.AppendAllText(_path, outputMessage);
            }
        }
    }
}
