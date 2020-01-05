using LoggerLibrary.Appenders.Contracts;
using LoggerLibrary.Layouts.Contracts;
using LoggerLibrary.Loggers;
using LoggerLibrary.Loggers.Contracts;
using System;
using System.Collections.Generic;


namespace LoggerLibrary
{
    class Engine
    {
        ICommandInterpreter _commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this._commandInterpreter = commandInterpreter;
        }
        public void Start()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] appenderConfig = Console.ReadLine().Split();
                _commandInterpreter.AddAppender(appenderConfig);
            }
            while (true)
            {
                string message = Console.ReadLine();
                if (message == "END")
                    break;
                string[] messageArgs = message.Split("|");
                _commandInterpreter.AddMessage(messageArgs);
            }
        }

    }
}
