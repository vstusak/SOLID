using System.Collections.Generic;

namespace SOLID
{
    partial class Program
    {
        public class BasicCalculator : ICalculator
        {
            public float Calculate(float value1, float value2, IArithmeticOperation mathOperation)
            {
                return mathOperation.GetResult(value1, value2);
            }
        }
    }
}