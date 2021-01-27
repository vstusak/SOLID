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
            public float GetResult(IEnumerable<float> operands)
            {
                var values = operands.ToList();
                return values[0] * values[1];
            }
        }
    }
}