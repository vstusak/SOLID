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
            var calculator = new Calculator();
            var operations = new Operations();

            consoleActions.GetOperator(inputOutputData, @"Set Command (+, -, *, /)");
            consoleActions.GetValues(inputOutputData, "set value 1", "set value 2");

            calculator.Calculate2(inputOutputData);
            //calculator.Calculate(operations, inputOutputData);

            consoleActions.ReturnResult(inputOutputData);
        }
    }
}
