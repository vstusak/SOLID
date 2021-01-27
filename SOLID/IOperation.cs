using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface IOperation
    {
        public string Name { get; set; }          

        public string Description();

        public IOperationResult Result { get; set; }
    }

    public interface IOperationResult
    {
        public int Value { get; set; }

        public string Description { get; set; }
    }

    public class OperationResult : IOperationResult
    {
        public OperationResult(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public string Description { get; set; }
    }

    public interface IUnaryOperation : IOperation
    {        
        public void Compute(IOperand operand);
    }

    public interface IBinaryOperation : IOperation
    {     
        public void Compute(IOperand operandA, IOperand operandB);
    }
            
}
