using System;

namespace SOLID.Operations
{
    public class DivOperation : IOperation
    {
        public int Calculate(int value1, int value2)
        {
            if (value2 == 0)
            {
                throw new NotSupportedException("Division by zero is not supported.");
            }
            return value1 / value2;
        }

        private static int CalculateRemainder(int value1, int value2)
        {
            return value1 % value2;
        }

        public string GetCalculationString(int value1, int value2)
        {
            var division = Calculate(value1, value2);
            var remainder = CalculateRemainder(value1, value2);
            var divisionString = $"{value1} / {value2} = {division}";
            var remainderString = remainder == 0 ? string.Empty : $" (Remainder: {CalculateRemainder(value1, value2)})";
            return $"{divisionString}{remainderString}";
        }
    }
}