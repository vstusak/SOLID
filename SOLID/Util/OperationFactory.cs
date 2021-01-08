using System;
using SOLID.Operations;

namespace SOLID.Util
{
    public class OperationFactory
    {
        public IOperation PromptForOperation()
        {
            Console.WriteLine($"Set Operation ({GetOperationList()})");
            var key = Console.ReadKey();
            Console.WriteLine();
            return GetOperation(key.KeyChar);
        }
        
        private IOperation GetOperation(char operationSymbol)
        {
            return operationSymbol switch
            {
                '+' => new AddOperation(),
                '-' => new SubOperation(),
                '*' => new MulOperation(),
                '/' => new DivOperation(),
                'q' => new QuitOperation(),
                _ => throw new NotSupportedException($"Operation '{operationSymbol}' not supported.")
            };
        }

        private string GetOperationList()
        {
            //var builder = new StringBuilder();
            //var operationType = typeof(IOperation);
            //var operations = AppDomain.CurrentDomain
            //    .GetAssemblies()
            //    .SelectMany(a => a.GetTypes())
            //    .Where(x => operationType.IsAssignableFrom(x));
            //foreach (IOperation operation in operations)
            //{
            //    builder.Append(operation.GetOperationSymbol());
            //    builder.Append(",");
            //}

            //return builder.ToString();
            return "+, -, *, /, q";
        }
    }
}
