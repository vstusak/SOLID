using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class AddOperation : IBinaryOperation
    {
        public string Name { get; set; }
        public IOperationResult Result { get; set; }

        public AddOperation(string name)
        {
            Name = name;
        }

        public string Description()
        {            
            return $"{Name}";
        }

        public void Compute(IOperand operandA, IOperand operandB)
        {                                 
            Result.Value = operandA.Value + operandB.Value;
            Result.Description = $"{operandA.Value} {Name} {operandB.Value} = {Result.Value}";
        }
        
    }

    public class Division : IBinaryOperation
    {
        //public IOperand OperandA { get; set; }
        //public IOperand OperandB { get; set; }
        public string Name { get; set; }

        public IOperationResult Result { get; set; }


        public void Compute(IOperand operandA, IOperand operandB)
        {            
            Result.Value = operandA.Value - operandB.Value;
            Result.Description = $"{operandA.Value} {Name} {operandB.Value} = {Result.Value}";
        }

        public string Description()
        {
            return $"{Name}";
        }
    }
}
