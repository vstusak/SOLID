using System;

namespace SOLID
{
    partial class Program
    {
        public class ConsoleOutputWriter : IOutputWriter
        {
            public void Write(string output)
            {
                Console.WriteLine($"\n{output}");
            }
        }
    }
}