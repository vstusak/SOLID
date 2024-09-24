using System;
using System.IO;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set Command (+. -, *, /");
            var key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '+':
                    Add();
                    break;
                case '-':
                    Sub();
                    break;
                case '*':
                    Mul();
                    break;
                case '/':
                    Div();
                    break;
                default:
                    Console.WriteLine("Not supported");
                    break;
            }
        }

        private static void Add()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 + value2;

            var output = $"{value1} + {value2} = {result}";
            Console.WriteLine(output);
            LogHistory(output);
        }

        private static void Sub()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 - value2;

            var output = $"{value1} - {value2} = {result}";
            Console.WriteLine(output);
            LogHistory(output);
        }

        private static void Mul()
        {
            throw new NotImplementedException();
        }

        private static void Div()
        {
            throw new NotImplementedException();
        }

        private static void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }
    }
}
