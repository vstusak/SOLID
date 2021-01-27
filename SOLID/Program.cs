using SOLID.Helpers.ConsoleOperations;

namespace SOLID
{
    class Program
    {        
        static void Main()
        {
            var consoleOutput = new ConsoleOutput();
            var calculator = new Calculator();

            consoleOutput.Print("Set Command (+. -, *, /");

            calculator.Calculate();
        }
    }
}
