using System;

namespace SOLID.Operations
{
    public class DivOperation : IOperation
    {
        private const string OperationName = "Division";
        public string GetOperationName()
        {
            return OperationName;
        }
        public string GetOperationSymbol()
        {
            return "/";
        }

        public int Calculate(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Division by zero is not supported.");
            }
            return dividend / divisor;
        }

        private static int CalculateRemainder(int dividend, int divisor)
        {
            return dividend % divisor;
        }

        public string GetCalculationString(int dividend, int divisor)
        {
            var division = Calculate(dividend, divisor);
            var remainder = CalculateRemainder(dividend, divisor);
            var divisionString = $"{dividend} / {divisor} = {division}";
            var remainderString = remainder == 0 ? string.Empty : $" (Remainder: {CalculateRemainder(dividend, divisor)})";
            return $"{divisionString}{remainderString}";
        }
    }
}