using System;

namespace SOLID.Operations
{
    class OperationFactory
    {
        public IOperation ChooseOperation(char operation)
        {
            return operation switch
            {
                '+' => new Addition(),
                '-' => new Subtraction(),
                '*' => new Multiplication(),
                '/' => new Division(),
                _ => throw new NotSupportedException($"Not supported.")
            };
        }
    }
}
