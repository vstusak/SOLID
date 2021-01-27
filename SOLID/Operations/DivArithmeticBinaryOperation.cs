using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    partial class Program
    {
        public class DivArithmeticBinaryOperation : IArithmeticOperation
        {
            public char Operator { get; set; }

            public DivArithmeticBinaryOperation(char mathOperator)
            {
                Operator = mathOperator;
            }
            public float GetResult(float value1, float value2)
            {
                return value1 / value2;
            }
        }
    }
}