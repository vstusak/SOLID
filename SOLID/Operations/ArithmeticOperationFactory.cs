using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID
{
    partial class Program
    {
        public class ArithmeticOperationFactory
        {
            private readonly IEnumerable<IArithmeticOperation> _arithmeticOperations;

            public ArithmeticOperationFactory()
            {
                _arithmeticOperations = new List<IArithmeticOperation>
                {
                    new AddArithmeticBinaryOperation('+'),
                    new SubArithmeticBinaryOperation('-'),
                    new MulArithmeticBinaryOperation('*'),
                    new DivArithmeticBinaryOperation('/')
                };
            }
            public IArithmeticOperation Create(char command)
            {
                return _arithmeticOperations.FirstOrDefault(ao => ao.Operator == command) ?? new UnknownArithmeticOperation(command);
            }
        }
    }
}