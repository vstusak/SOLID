using System;

namespace SOLID.Helpers.ConsoleOperations
{
    class ConsoleInput
    {
        public char GetOperation()
        {
            return Console.ReadKey().KeyChar;
        }

        public int GetValue()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
