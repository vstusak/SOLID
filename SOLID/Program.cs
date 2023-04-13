using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace SOLID
{
    internal class Program
    {
        public static int Value1;
        public static int Value2;
        public static ConsoleKeyInfo OperatorKey;
        public static string Output;

        static void Main(string[] args)
        {
            //TODO: pass values
            var calculator = new Calculator();

            calculator.GetValues();
            calculator.GetOperator();
            calculator.Count(OperatorKey, Value1, Value2);
            calculator.LogHistory(Output);
        }
    }
}