using System;

namespace SOLID
{
    partial class Program
    {
        private class ConsoleNumberReader : INumberReader
        {
            public float Read()
            {
                Console.WriteLine("\nSet value: ");
                if (float.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }

                throw new Exception("Input string is not a number.");
            }
        }
    }
}