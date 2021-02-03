namespace SOLID.Operations
{
    public interface IOperator
    {
        string GetOperatorSymbol();
        string GetOperatorName();
        int DoCalc(int val1, int val2);
        string GetCalcString(int val1, int val2);
    }
}
