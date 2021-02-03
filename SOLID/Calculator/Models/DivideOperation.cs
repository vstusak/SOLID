using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Calculator
{
    public class DivideOperation : IOperation
    {
        public char AcceptedInput => '/';

        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new ArgumentOutOfRangeException(paramName: "Denominator", message: "Can't divide by zero");
            }
            return first / second;
        }
    }
}
