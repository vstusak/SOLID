using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID
{
    internal class Calculator : ICalculator
    {
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
            var result = Execute(operatorKey, value1, value2);
            Console.WriteLine($"{result}");
        }

        public void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }

        public int Execute(ConsoleKeyInfo operatorKey, int value1, int value2)
        {
            var result = 0;
            switch (operatorKey.KeyChar)
            {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '*':
                    result = value1 / value2;
                    break;
                case '/':
                    result = value1 * value2;
                    break;
                default:
                    Console.WriteLine("Not supported");
                    break;
            }

            return result;
        }
    }
}