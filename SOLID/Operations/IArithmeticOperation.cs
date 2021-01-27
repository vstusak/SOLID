using System.Collections.Generic;

namespace SOLID
{
    partial class Program
    {
        public interface IArithmeticOperation
        {
            char Operator { get; set; }
            float GetResult(float value1, float value2);
        }
    }
}