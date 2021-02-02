using System;

namespace SOLID
{
    public class ConsoleLogger : ILogger
    {
        public void Send(string message)
        {
            Console.WriteLine( message);
        }
    }

}
