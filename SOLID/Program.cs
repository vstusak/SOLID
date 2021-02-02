using System;
using System.IO;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();

            var operationsFactory = new OperationsProvider();

            var reader = new ConsoleReader(operationsFactory);

            var operation = reader.GetOperation();

            if (operation is UnknownOperation)
            {
                logger.Send($"Operation {operation.Operator} not supported");                
            }
            else
            {
                var operators = reader.GetOperands();
                var result = operation.Compute(operators.Item1, operators.Item2);                
                logger.Send(result.Description);
            }

            logger.Send("Finished, exiting");
        }        
    }
}
