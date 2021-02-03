using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Utilities
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"\n{DateTime.UtcNow}: {message}");
        }
    }
}
