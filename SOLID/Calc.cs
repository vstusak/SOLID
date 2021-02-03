using System;
using SOLID.InputOutput;
using SOLID.Util;

namespace SOLID
{
    public class Calc
    {
        private readonly GetOperand _valueGetter;
        private readonly OperatorFactory _operatorFactory;
        private readonly IOutput _output;

        public Calc(GetOperand getOperand, OperatorFactory operatorFactory, IOutput output)
        {
            _valueGetter = getOperand;
            _operatorFactory = operatorFactory;
            _output = output;
        }

        public void RunCalculator()
        {
            try
            {
                var operation = _operatorFactory.PromptForOperator();

                var firstValue = _valueGetter.PromptValue();
                var secondValue = _valueGetter.PromptValue();
                var calculationString = operation.GetCalcString(firstValue, secondValue);
                _output.Print(calculationString);
            }
            catch (DivideByZeroException)
            {
                const string exceptionString = "Division by zero is not valid.";
                _output.Print(exceptionString);
            }
            catch (NotSupportedException exception)
            {
                var exceptionString = $"Not supported: {exception.Message}";
                _output.Print(exceptionString);
            }
            catch (Exception exception)
            {
                var exceptionString = $"Unknown exception occurred: {exception.Message}. Stopping calculator.";
                _output.Print(exceptionString);
            }
            finally
            {
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
