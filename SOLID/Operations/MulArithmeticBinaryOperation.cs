using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    partial class Program
    {
        public class MulArithmeticBinaryOperation : IArithmeticOperation
        {
            public char Operator { get; set; }

            public MulArithmeticBinaryOperation(char mathOperator)
            {
                Operator = mathOperator;
            }
            public float GetResult(float value1, float value2)
            {
                return value1 * value2;
            }
        }
    }
}