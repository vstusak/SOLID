using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Models;
using SOLID.Strategies;

namespace SOLID
{
    public class CalculatorProvider : ICalculatorProvider
    {
        private ICalculationStrategy _calculationStrategy;

        public CalculatorProvider(ICalculationStrategy calculationStrategy)
        {
            _calculationStrategy = calculationStrategy;
        }

        public void SetStrategy(ICalculationStrategy strategy)
            => _calculationStrategy = strategy;

        public int Calculate(Input input)
            => _calculationStrategy.CalculateInner(input.FirstNumber, input.SecondNumber);
    }
}
