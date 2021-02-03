namespace SOLID.Operations
{
    public class Subtract : IOperator
    {
        private const string OperatorName = "Subtract";
        private const string OperatorSymbol = "-";

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
            return val1 - val2;
        }

        public string GetCalcString(int val1, int val2)
        {
            return $"{val1} {OperatorSymbol} {val1} = {DoCalc(val1, val2)}";
        }
    }
}