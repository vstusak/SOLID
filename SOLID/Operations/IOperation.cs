namespace SOLID.Operations
{
    internal interface IOperation
    {
        int Calculate(int number1, int number2);
        void ReturnResult(int number1, int number2);
    }
}