using System;

namespace SOLID
{
    public class UnknownOperation : IOperation
    {
        public char Operator { get => 'E'; }

        public IOperationResult Compute(IOperand operand1, IOperand operand2)
        {
            throw new NotImplementedException();
        }
    }
}
