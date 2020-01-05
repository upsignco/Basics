using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Appenders
{
    interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
