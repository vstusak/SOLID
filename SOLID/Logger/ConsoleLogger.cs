using System;

namespace SOLID.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Write(object output)
        {
            Console.WriteLine(output);
        }
    }
}