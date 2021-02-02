using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface IOperation
    {
        public char Operator { get; }

        public IOperationResult Compute(IOperand operand1, IOperand operand2);
    }

}
