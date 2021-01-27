using System;
using System.Collections.Generic;

namespace SOLID
{
    partial class Program
    {
        public class UnknownArithmeticOperation : IArithmeticOperation
        {
            public char Operator { get; set; }

            public UnknownArithmeticOperation(char mathOperator)
            {
                Operator = mathOperator;
            }
            public float GetResult(IEnumerable<float> operands)
            {
                throw new Exception($"Unknown operation '{Operator}'");
            }
        }
    }
}