using LoggerLibrary.Loggers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Loggers
{
    class LogFile : ILogFile
    {
        StringBuilder messages;
        public LogFile()
        {
            messages = new StringBuilder();
        }
        public void Write(string message)
        {
            messages.Append(message);
        }
    }
}
