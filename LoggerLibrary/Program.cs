using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(new CommandInterpreter());
            engine.Start();
        }
    }
}
