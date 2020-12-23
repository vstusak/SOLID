using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Models;
using SOLID.Strategies;

namespace SOLID.Factories
{
    public class CalculationStrategyFactory : ICalculationStrategyFactory
    {
        private readonly ICalculatorProvider _calculatorProvider;
        private readonly AddCalculationStrategy _addStrategy;
        private readonly SubtractCalculationStrategy _subtractStrategy;
        private readonly MultiplyCalculationStrategy _multiplyStrategy;
        private readonly DivideCalculationStrategy _divideStrategy;

        public CalculationStrategyFactory(ICalculatorProvider calculatorProvider,
            AddCalculationStrategy addStrategy,
            SubtractCalculationStrategy subtractStrategy,
            MultiplyCalculationStrategy multiplyStrategy,
            DivideCalculationStrategy divideStrategy)
        {
            _calculatorProvider = calculatorProvider;
            _addStrategy = addStrategy;
            _subtractStrategy = subtractStrategy;
            _multiplyStrategy = multiplyStrategy;
            _divideStrategy = divideStrategy;
        }
        public void Set(Operand operand)
        {
            //var type = typeof(ICalculationStrategy);
            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(s => s.GetTypes())
            //    .Where(p => type.IsAssignableFrom(p));

            switch (operand)
            {
                case Operand.Add:
                    _calculatorProvider.SetStrategy(_addStrategy);
                    break;
                case Operand.Multiply:
                    _calculatorProvider.SetStrategy(_multiplyStrategy);
                    break;
                case Operand.Subtract:
                    _calculatorProvider.SetStrategy(_subtractStrategy);
                    break;
                case Operand.Divide:
                    _calculatorProvider.SetStrategy(_divideStrategy);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
