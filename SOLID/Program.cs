using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace SOLID
{
    internal class Program
    {
        private static int _value1;
        private static int _value2;
        private static ConsoleKeyInfo _operatorKey;
        private static string _output;

        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var action = new Action();

            action.GetValues();
            action.GetOperator();
            action.Count(_operatorKey, _value1, _value2);
            calculator.LogHistory(_output);
        }
    }
}