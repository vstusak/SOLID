using SOLID.Interfaces;
using SOLID.Operations;
using System;

namespace SOLID
{
    public class Calculator : ICalculators
    {
        public (int, int) ReadNumbers()
        {
            Console.WriteLine("\nset value 1");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("set value 2");
            var secondNumber = int.Parse(Console.ReadLine());

            Logger.LogHistory($"Operands: {firstNumber}, {secondNumber}");

            return (firstNumber, secondNumber);
        }

        public char ReadOperation()
        {
            Console.WriteLine("Set Command (+. -, *, /");
            var operation = Console.ReadKey().KeyChar;

            Logger.LogHistory("Operation: " + operation);

            return operation;
        }

        public int PerformCalculation((int, int) numbers, char operation)
        {
            switch (operation)
            {
                case '+':
                    var add = new Add(numbers);
                    return add.Result;

                case '-':
                    var sub = new Sub(numbers);
                    return sub.Result;

                case '*':
                    var mul = new Mul(numbers);
                    return mul.Result;

                case '/':
                    var div = new Div(numbers);
                    return div.Result;

                default:
                    Console.WriteLine("Not supported");
                    throw new NotImplementedException();
            }
        }

        public void PrintResult(double result)
        {
            Console.WriteLine("\nResult of calculation: " + result);

            Logger.LogHistory($"Result: {result}");
        }
    }
}