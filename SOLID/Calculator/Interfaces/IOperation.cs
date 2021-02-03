namespace SOLID.Calculator
{
    public interface IOperation
    {
        char AcceptedInput { get; }
        double Calculate(double first, double second);
    }
}