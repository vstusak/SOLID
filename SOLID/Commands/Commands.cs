using System;

namespace SOLID.Commands
{
    public class AddCommand : ICommand
    {
        public decimal Execute(decimal firstNumber, decimal secondNumber)
        {
            return Decimal.Add(firstNumber, secondNumber);
        }
    }

    public class SubCommand : ICommand
    {
        public decimal Execute(decimal firstNumber, decimal secondNumber)
        {
            return Decimal.Subtract(firstNumber, secondNumber);
        }
    }

    public class MulCommand : ICommand
    {
        public decimal Execute(decimal firstNumber, decimal secondNumber)
        {
            return Decimal.Multiply(firstNumber, secondNumber);
        }
    }

    public class DivCommand : ICommand
    {
        public decimal Execute(decimal firstNumber, decimal secondNumber)
        {
            return Decimal.Divide(firstNumber, secondNumber);
        }
    }
}