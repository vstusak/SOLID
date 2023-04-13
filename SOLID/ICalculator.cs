using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SOLID
{
    internal interface ICalculator
    {
        (int value1, int value2) GetValues();
        ConsoleKeyInfo GetOperator();
        int Execute(ConsoleKeyInfo operatorKey, int value1, int value2);
        void Count(ConsoleKeyInfo operatorKey, int value1, int value2);
        void LogHistory(string output);
    }
}