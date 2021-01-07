using System;
using SOLID.Logging;
using SOLID.Util;

namespace SOLID
{
    public class Calculator
    {
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public void RunCalculator()
        {
            while (true)
            {
                try
                {
                    var operationDecider = new OperationDecider();
                    var operation = operationDecider.PromptForOperation();
                    _logger.Log($"Operation selected: {operation.GetOperationName()}");
                    var valueGetter = new ValueGetter();

                    var value1 = valueGetter.PromptForValue();
                    _logger.Log($"Value entered: {value1}");
                    var value2 = valueGetter.PromptForValue();
                    _logger.Log($"Value entered: {value2}");
                    var output = operation.GetCalculationString(value1, value2);
                    Console.WriteLine(output);
                    _logger.Log(output);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception occurred: {e.Message}");
                    _logger.Log($"Exception occurred: {e.Message}");
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
