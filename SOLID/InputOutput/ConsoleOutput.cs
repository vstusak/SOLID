using System;

namespace SOLID.InputOutput
{
    public class ConsoleOutput : IOutput
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
