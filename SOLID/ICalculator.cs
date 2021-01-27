using System.Collections.Generic;

namespace SOLID
{
    partial class Program
    {
        private interface ICalculator
        {
            float Calculate(IEnumerable<float> operands, IArithmeticOperation mathOperation);
        }
    }
}