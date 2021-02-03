using SOLID.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Calculator
{
    public class BasicCalculator : ICalculator
    {
        private readonly ILogger _logger;

        public BasicCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public double Calculate(double firstInput, double secondInput, IOperation operation)
        {
            if(operation == null)
            {
                throw new ArgumentNullException($"{nameof(operation)} can't be null");
            }

            var result = operation.Calculate(first: firstInput, second: secondInput);
            _logger.Log($"Calculator {nameof(BasicCalculator)} starting calculation: operation: {nameof(operation)}first input {firstInput}, second input {secondInput} with result {result}");

            return result;
        }
    }
}
