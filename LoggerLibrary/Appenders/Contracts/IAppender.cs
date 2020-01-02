using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Appenders.Contracts
{
    //responsible for appending the messages somewhere 
    interface IAppender
    {
        void Append();
    }
}
