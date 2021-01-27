using System.Collections.Generic;

namespace SOLID
{
    partial class Program
    {
        public class BasicCalculator : ICalculator
        {
            public float Calculate(IEnumerable<float> operands, IArithmeticOperation mathOperation)
            {
                return mathOperation.GetResult(operands);
            }
        }
    }
}