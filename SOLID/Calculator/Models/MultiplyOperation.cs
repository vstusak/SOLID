using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Calculator
{
    public class MultiplyOperation : IOperation
    {
        public char AcceptedInput => '*';

        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
