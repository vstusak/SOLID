using System;

namespace SOLID.InputOutput
{
    public class Output : IOutput
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
