using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace SOLID
{
    internal class Program
    {
        private static int _value1;
        private static int _value2;
        private static ConsoleKeyInfo _operatorKey;
        private static string _output = "Output!";

        static void Main(string[] args)
        {
            var action = new Action();
            var logger = new MyLogger();

            action.GetValues();
            action.GetOperator();
            action.Count(_operatorKey, _value1, _value2); //-> calculator
            //calculator.LogHistory(_output); //calculator -> logger
            logger.LogHistory(_output);
        }
    }
}