namespace SOLID.Operations
{
    public class Subtract : IOperator
    {
        private const string _operatorName = "Subtract";
        private const string _operatorSymbol = "-";

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
            return val1 - val2;
        }

        public string GetCalcString(int val1, int val2)
        {
            return $"{val1} {_operatorSymbol} {val1} = {DoCalc(val1, val2)}";
        }
    }
}