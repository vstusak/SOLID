using System;

namespace SOLID.InputReader
{
    public class ConsoleReader:IInputReader
    {
        public char ReadOperation()
        {
            return Console.ReadKey().KeyChar;
        }

        public string ReadValue()
        {
            return Console.ReadLine();
        }
    }
}