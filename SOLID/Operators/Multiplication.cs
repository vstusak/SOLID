using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Multiplication : IOperator
    {
        public double Calculate(double number1, double number2) {return number1 * number2;}
    }
}
