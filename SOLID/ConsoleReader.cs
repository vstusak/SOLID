using System;

namespace SOLID
{
    public class ConsoleReader : IReader
    {
        private readonly OperationsProvider _provider;
        public ConsoleReader(OperationsProvider provider)
        {
            _provider = provider;
        }

        public Tuple<IOperand, IOperand> GetOperands()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            return new Tuple<IOperand, IOperand>(new IntegerOperand(value1), new IntegerOperand(value2));
        }

        public IOperation GetOperation()
        {            
            Console.WriteLine("Set Command " + String.Join<char> ("|" , _provider.GetAvailableOperators() ) );
            var key =  Console.ReadKey();


            if (! _provider.OperationExists(key.KeyChar))
            {
                return new UnknownOperation();
            }

            var operation = _provider.GetOperation(key.KeyChar);
            return operation;
            
                
        }
    }

}
