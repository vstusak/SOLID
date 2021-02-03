using SOLID.Utilities;
using SOLID.Calculator;
using System;
using System.IO;

namespace SOLID
{
    class Program
    {
        private static readonly char _exitKey = 'X';

        static void Main(string[] args)
        {
            bool shouldRun = true;

            var logger = new ConsoleLogger();
            var calculator = new BasicCalculator(logger);

            while (shouldRun)
            {
                PrintMenu();
                var operationKey = Console.ReadKey();

                //TODO: Find a way to compare Lower input that isn't clunky
                if (operationKey.KeyChar == _exitKey)
                {
                    return;
                }

                var operation = OperationFactory.Create(operationKey.KeyChar);
                if (operation == null)
                {
                    Console.WriteLine($"\nSelect a valid operation");
                    continue;
                }

                try
                {
                    Console.Write("\nFirst number: ");
                    var firstInput = GetInput();

                    Console.Write("\nSecond number: ");
                    var secondInput = GetInput();

                    var result = calculator.Calculate(firstInput: firstInput, secondInput: secondInput, operation: operation);
                    Console.WriteLine($"\n{firstInput} {operation.AcceptedInput} {secondInput} = {result}");
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static double GetInput()
        {
            var input = Console.ReadLine();
            bool isValid = double.TryParse(input, out double result);
            if (!isValid)
            {
                throw new ArgumentException($"{input} is not a valid number");
            }
            return result;
        }

        private static void PrintMenu()
        {
            var commands = OperationFactory.AvailableCommands();
            Console.Write($"Set Command ({string.Join(',', commands)}) to calculate or {_exitKey} to exit: ");
        }
    }
}
