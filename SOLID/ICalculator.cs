using System.Collections.Generic;

namespace SOLID
{
    partial class Program
    {
        private interface ICalculator
        {
            float Calculate(float value1, float value2, IArithmeticOperation mathOperation);
        }
    }
}