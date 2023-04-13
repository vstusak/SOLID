using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal interface IAction
    {
        (int value1, int value2) GetValues();
        ConsoleKeyInfo GetOperator();
        void Count(ConsoleKeyInfo operatorKey, int value1, int value2);

    }
}