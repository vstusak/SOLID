namespace SOLID.Operations
{
    public interface IOperator
    {
        string GetOperatorSymbol();
        string GetOperatorName();
        int DoCalc(int value1, int value2);
        string GetCalcString(int value1, int value2);
    }
}
