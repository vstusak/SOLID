using System;

namespace SOLID.Operations
{
    public class Division : IOperator
    {
        private const string OperatorName = "Division";
        private const string OperatorSymbol = "/";

        public string GetOperatorName()
        {
            return OperatorName;
        }
        public string GetOperatorSymbol()
        {
            return OperatorSymbol;
        }

        public int DoCalc(int val1, int val2)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not supported.");
            }
            if (val1 % val2 != 0)
            {
                throw new NotSupportedException("Division with reminder is not supported.");
            }
            return val1 / val2;
        }

        public string GetCalcString(int val1, int val2)
        {
            return $"{val1} {OperatorSymbol} {val2} = {DoCalc(val1, val2)}";
        }
    }
}