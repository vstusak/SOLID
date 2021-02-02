namespace SOLID
{
    public class DivOperation : IOperation
    {
        public char Operator { get => '/'; }

        public IOperationResult Compute(IOperand operand1, IOperand operand2)
        {
            if (operand2.Value == 0)
            {
                var result = new InvalidOperationResult();
                result.Description = $"{operand1.Value} {Operator} {operand2.Value} = INVALID RESULT ";
                return result;
            }
            else
            {
                var result = new OperationResult(operand1.Value / operand2.Value);
                result.Description = $"{operand1.Value} {Operator} {operand2.Value} = {result.Value}";
                return result;
            }

        }
    }
}
