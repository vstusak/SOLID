using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Strategies
{
    public class MultiplyCalculationStrategy : ICalculationStrategy
    {
        public int CalculateInner(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
