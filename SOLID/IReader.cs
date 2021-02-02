using System;

namespace SOLID
{
    public interface IReader
    {
        public IOperation GetOperation();

        public Tuple<IOperand, IOperand> GetOperands();
    }

}
