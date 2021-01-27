using System;

namespace SOLID
{
    partial class Program
    {
        public class ConsoleCommandReader : ICommandReader
        {
            public char Read()
            {
                Console.WriteLine("Set Command (+, -, *, /)");
                return Console.ReadKey().KeyChar;
            }
        }
    }
}