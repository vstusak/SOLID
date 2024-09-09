using System;
using System.IO;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("Set Command (+. -, *, /");
            var key = Console.ReadKey();
            //char.Parse(key);
            //ConsoleKeyInfo key = Console.ReadKey();
            ////key = Convert.ConsoleKeyInfo();
            calculator.Calculate(key);

        }

    }
}
