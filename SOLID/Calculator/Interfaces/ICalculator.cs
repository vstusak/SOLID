using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Calculator
{
    public interface ICalculator
    {
        double Calculate(double firstInput, double secondInput, IOperation operation);
    }
}
