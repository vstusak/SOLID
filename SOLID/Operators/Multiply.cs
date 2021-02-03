namespace SOLID.Operations
{
    public class Multiply : IOperator
    {
        private const string _operatorName = "Multiplication";
        private const string _operatorSymbol = "*";

        public string GetOperatorName()
        {
            return _operatorName;
        }

        public string GetOperatorSymbol()
        {
            return _operatorSymbol;
        }

        public int DoCalc(int val1, int val2)
        {
            return val1 * val2;
        }

        public string GetCalcString(int val1, int val2)
        {
            return $"{val1} {_operatorSymbol} {val2} = {DoCalc(val1, val2)}";
        }
    }
}