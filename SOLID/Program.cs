using System;
using System.IO;
using Microsoft.VisualBasic;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            calculator.GetValues();
            calculator.GetOperator();
            calculator.Count();
            calculator.LogHistory(output);
        }
    }
}