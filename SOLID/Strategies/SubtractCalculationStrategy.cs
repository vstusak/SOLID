using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Strategies;

namespace SOLID
{
    public class SubtractCalculationStrategy : ICalculationStrategy
    {
        public int CalculateInner(int firstValue, int secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
