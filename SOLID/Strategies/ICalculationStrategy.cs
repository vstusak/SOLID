using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Strategies
{
    public interface ICalculationStrategy
    {
        int CalculateInner(int firstValue, int secondValue);
    }
}
