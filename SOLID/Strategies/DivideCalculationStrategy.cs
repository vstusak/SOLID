using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Strategies
{
    public class DivideCalculationStrategy : ICalculationStrategy
    {
        public int CalculateInner(int firstValue, int secondValue)
        {
            if (secondValue == 0)
                throw new DivideByZeroException(nameof(secondValue));

            return firstValue / secondValue;
        }
    }
}
