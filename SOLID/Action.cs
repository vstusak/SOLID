using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class Action : IAction
    {
        public void GetResult()
        {
            throw new NotImplementedException();
        }

        public void LogHistory()
        {
            throw new NotImplementedException();
        }

        public void OutputResult()
        {
            throw new NotImplementedException();
        }

        public void SetOperator(ConsoleKeyInfo operatorKey)
        {
            switch (operatorKey.KeyChar)
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

        public (ConsoleKeyInfo operatorKey, int value1, int value2) SetEquation()
        {
            Console.WriteLine($"\nSet operator +. -, * or / on your numeric keyboard:\n");
            var operatorKey = Console.ReadKey();

            Console.WriteLine($"\nSet value n.1:\n");
            var value1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSet value n.2:\n");
            var value2 = int.Parse(Console.ReadLine());

            return (operatorKey, value1, value2);
        }
    }
}