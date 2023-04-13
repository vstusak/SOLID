using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class Action
    {
        Calculator calculator = new Calculator();

        public (int value1, int value2) GetValues()
        {
            Console.WriteLine($"\nSet value n.1:\n");
            var value1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSet value n.2:\n");
            var value2 = int.Parse(Console.ReadLine());

            return (value1, value2);
        }

        public ConsoleKeyInfo GetOperator()
        {
            Console.WriteLine($"\nSet operator +. -, * or / on your numeric keyboard:\n");
            return Console.ReadKey();
        }

        public void Count(ConsoleKeyInfo operatorKey, int value1, int value2)
        {
            Console.WriteLine($"{value1}{operatorKey}{value2} = ");
            var result = calculator.Execute(operatorKey, value1, value2);
            Console.WriteLine($"{result}");
        }
    }
}
