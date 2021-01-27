using System;

namespace SOLID
{
    partial class Program
    {
        public class ArithmeticOperationFactory
        {
            private readonly int _operandsCount;

            public ArithmeticOperationFactory(int operandsCount)
            {
                _operandsCount = operandsCount;
            }
            public IArithmeticOperation Create(char command)
            {
                if (_operandsCount == 2)
                {
                    switch (command)
                    {
                        case '+':
                            return new AddArithmeticBinaryOperation(command);
                        case '-':
                            return new SubArithmeticBinaryOperation(command);
                        case '*':
                            return new MulArithmeticBinaryOperation(command);
                        case '/':
                            return new DivArithmeticBinaryOperation(command);
                        default:
                            return new UnknownArithmeticOperation(command);
                    }
                }
                else
                {
                    //logic for one operand or more than two operands
                    //now just throw exception
                    throw new NotImplementedException();
                }
            }
        }
    }
}