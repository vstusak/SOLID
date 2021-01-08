using System;
using SOLID.InputOutput;
using SOLID.Util;

namespace SOLID
{
    public class Calculator
    {
        private readonly ILogger _logger;
        private readonly ValueGetter _valueGetter;
        private readonly OperationFactory _operationFactory;
        private readonly IOutput _output;

        public Calculator(ValueGetter valueGetter, OperationFactory operationFactory, ILogger logger, IOutput output)
        {
            _valueGetter = valueGetter;
            _operationFactory = operationFactory;
            _logger = logger;
            _output = output;
        }

        public bool RunCalculator()
        {
            try
            {
                _valueGetter.ResetCounter();
                var operation = _operationFactory.PromptForOperation();
                _logger.Log($"Operation selected: {operation.GetOperationName()}");
                if (operation.GetOperationSymbol() == "q")
                {
                    return false;
                }
                
                var value1 = _valueGetter.PromptForValue();
                _logger.Log($"Value entered: {value1}");
                var value2 = _valueGetter.PromptForValue();
                _logger.Log($"Value entered: {value2}");
                var calculationString = operation.GetCalculationString(value1, value2);
                _output.Print(calculationString);
                _logger.Log(calculationString);
            }
            catch (NotSupportedException e)
            {
                var exceptionString = $"Not supported: {e.Message}";
                _output.Print(exceptionString);
                _logger.Log(exceptionString);
            }
            catch (DivideByZeroException)
            {
                const string exceptionString = "Division by zero is not valid.";
                _output.Print(exceptionString);
                _logger.Log(exceptionString);
            }
            catch (Exception e)
            {
                var exceptionString = $"Unknown exception occurred: {e.Message}. Stopping calculator.";
                _output.Print(exceptionString);
                _logger.Log(exceptionString);
                return false;
            }
            finally
            {
                Console.WriteLine();
            }
            return true;
        }
    }
}
