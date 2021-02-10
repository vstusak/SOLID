using SOLID.Data;
using SOLID.Operation;
using SOLID.OperationCalculate;
using System;

namespace SOLID
{
    public class Calculator
    {
        public void Calculate(Operations operations, InputOutputData inputOutputData)
        {
            switch (inputOutputData.Operator)
            {
                case '+':
                    operations.Add(inputOutputData);
                    break;
                case '-':
                    operations.Sub(inputOutputData);
                    break;
                case '*':
                    operations.Mul(inputOutputData);
                    break;
                case '/':
                    operations.Div(inputOutputData);
                    break;
                default:
                    Console.WriteLine($"Not supported operator [{inputOutputData.Operator}].");
                    System.Environ­ment.Exit(0);
                    break;
            }
        }

        public void Calculate2(InputOutputData inputOutputData)
        {
            var addOperation = new AddOperation();
            var divOperation = new DivOperation();
            var subOperation = new SubOperation();
            var mulOperation = new MulOperation();

            switch (inputOutputData.Operator)
            {
                case '+':
                    addOperation.Calculate(inputOutputData);

                    break;
                case '-':
                    subOperation.Calculate(inputOutputData);
                    break;
                case '*':
                    mulOperation.Calculate(inputOutputData);
                    break;
                case '/':
                    divOperation.Calculate(inputOutputData);
                    break;
                default:
                    Console.WriteLine($"Not supported operator [{inputOutputData.Operator}].");
                    System.Environ­ment.Exit(0);
                    break;
            }
        }
    }
}
