using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID
{
    internal class Calculator : ICalculator
    {


        //public void LogHistory(string output)
        //{
        //    File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        //}

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