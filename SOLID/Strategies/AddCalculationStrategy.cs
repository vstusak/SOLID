using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Models;

namespace SOLID.Strategies
{
    public class AddCalculationStrategy : ICalculationStrategy
    {
        public int CalculateInner(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
