using System;
using SOLID.Operations;

namespace SOLID.Util
{
    public class OperatorFactory
    {
        public IOperator PromptForOperator()
        {
            Console.WriteLine($"Choose Operator +, -, *, /");
            var key = Console.ReadKey();
            Console.WriteLine();
            return GetOperator(key.KeyChar);
        }
        
        private IOperator GetOperator(char operatorSymbol)
        {
            return operatorSymbol switch
            {
                '+' => new Addition(),
                '-' => new Subtract(),
                '*' => new Multiply(),
                '/' => new Division(),
                _ => throw new NotSupportedException($"Operator '{operatorSymbol}' is not avaliable.")
            };
        }
    }
}
