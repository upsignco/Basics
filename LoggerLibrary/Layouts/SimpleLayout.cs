﻿using LoggerLibrary.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary.Layouts
{
    //format <date-time> - <report level> - <message>
    class SimpleLayout : ILayout
    {
        public string Format => "{0}-{1}-{2}";
    }
}
