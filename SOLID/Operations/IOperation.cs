namespace SOLID.Operations
{
    public interface IOperation
    {
        int Calculate(int value1, int value2);
        string GetCalculationString(int value1, int value2);
    }
}
