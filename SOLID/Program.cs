using System;
using System.IO;
using Microsoft.VisualBasic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Action userAction = new Action();
            //ask user to set command
            //get selected command
            //ask user to set value1
            //get selected value
            //ask user to set value2
            //get selected value
            //outputs result
            //logs history

            //action.SetCommand();
            //action.Set("value number one");
            //action.Set("value number two");
            //action.OutputResult();
            //action.LogHistory();

            action.SetEquation();
            action.Count();
            GetResult();
            LogHistory(output);
        }

        

        public void Count(ConsoleKeyInfo key, int value1, int value2)
        {

        }

        private static void Command(ConsoleKeyInfo key, int value1, int value2)
        {
            //set value1 - write and return
            Set("value n.1");
            value = value1;

            //setValue2
            Set("value n.2");
            value = value2;

            //getResult
            var charKey = key.KeyChar;
            var result = value1 + charKey + value2;

            //output result
            var output = $"{value1} + {value2} = {result}";
            Console.WriteLine(output);
            LogHistory(output);
        }

        private static void Add()
        {
            //set value1 - write and return
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());

            //setValue2
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            //getResult
            var result = value1 + value2;

            //output result
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
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 * value2;

            var output = $"{value1} - {value2} = {result}";
            Console.WriteLine(output);
            LogHistory(output);
        }

        private static void Div()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 / value2;

            var output = $"{value1} - {value2} = {result}";
            Console.WriteLine(output);
            LogHistory(output);
        }

        private static void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }
    }
}