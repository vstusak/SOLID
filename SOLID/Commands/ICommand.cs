namespace SOLID.Commands
{
    public interface ICommand
    {
        decimal Execute(decimal firstNumber, decimal secondNumber);
    }
}