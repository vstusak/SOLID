using SOLID.Data;
using SOLID.Operation;
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
    }
}
