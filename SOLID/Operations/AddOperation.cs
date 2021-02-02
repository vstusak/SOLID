using System.Text;

namespace SOLID
{
    class AddOperation : IOperation
    {        
        public char Operator { get => '+'; }            

        public IOperationResult Compute(IOperand operand1, IOperand operand2)
        {
            var result = new OperationResult(operand1.Value + operand2.Value);
            result.Description = $"{operand1.Value} {Operator} {operand2.Value} = {result.Value}";
            return result;
        }
    }
}
