using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Layouts.Contracts;
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
        public override void Append()
        {
            string message;
            Console.WriteLine(String.Format(this._layout.Format,message));
        }
    }
}
