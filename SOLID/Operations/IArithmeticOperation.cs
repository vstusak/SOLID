using System.Collections.Generic;

namespace SOLID
{
    partial class Program
    {
        public interface IArithmeticOperation
        {
            char Operator { get; set; }
            float GetResult(IEnumerable<float> operands);
        }
    }
}