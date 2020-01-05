using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary
{
    interface ICommandInterpreter
    {
        public void AddAppender(string [] appenderConfig)
        {
        }

        public void AddMessage(string [] messageArgs)
        {
        }
    }
}
