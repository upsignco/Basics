using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Appenders
{
    abstract class Appender : IAppender
    {
        protected ILayout _layout;
        public Appender(ILayout layout)
        {
            _layout = layout;
        }
        public abstract void Append();

    }
}
