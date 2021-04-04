using System;
using System.Collections.Generic;
using System.Text;

namespace Wot1
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string data)
        {
            Console.WriteLine(data);
        }
    }
}
