using SOLID.Data;
using SOLID.Operation;
using SOLID.IOActions;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOutputData = new InputOutputData();
            var consoleActions = new ConsoleActions();
            var operations = new Operations();
            var calculator = new Calculator();

            consoleActions.GetOperator(inputOutputData, @"Set Command (+, -, *, /)");
            consoleActions.GetValues(inputOutputData, "set value 1", "set value 2");

            calculator.Calculate(operations, inputOutputData);

            consoleActions.ReturnResult(inputOutputData);
        }
    }
}
