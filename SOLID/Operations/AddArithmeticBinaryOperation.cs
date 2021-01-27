using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    partial class Program
    {
        public class AddArithmeticBinaryOperation : IArithmeticOperation
        {
            public char Operator { get; set; }

            public AddArithmeticBinaryOperation(char mathOperator)
            {
                Operator = mathOperator;
            }

            public float GetResult(IEnumerable<float> operands)
            {
                var values = operands.ToList();
                return values[0] + values[1];
            }
        }
    }
}