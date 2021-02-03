namespace SOLID.Calculator
{
#warning Valid to use generics for return types (int vs floating point)?
#warning Naming: Add Operation sufix to implementations or leave as is (AddOperation vs Add)?
    public interface IOperation
    {
        char AcceptedInput { get; }
        double Calculate(double first, double second);
    }
}