using System;
using SOLID.Operations;

namespace SOLID.Util
{
    public class OperationDecider
    {
        public IOperation PromptForOperation()
        {
            Console.WriteLine("Set Operation (+, -, *, /)");
            var key = Console.ReadKey();
            Console.WriteLine();
            return GetOperation(key.KeyChar);
        }
        
        private static IOperation GetOperation(char operationSymbol)
        {
            return operationSymbol switch
            {
                '+' => new AddOperation(),
                '-' => new SubOperation(),
                '*' => new MulOperation(),
                '/' => new DivOperation(),
                _ => throw new NotSupportedException($"Operation '{operationSymbol}' not supported.")
            };
        }
    }
}
