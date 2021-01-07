namespace SOLID.Operations
{
    public class MulOperation : IOperation
    {
        private const string OperationName = "Multiplication";
        public string GetOperationName()
        {
            return OperationName;
        }
        
        public int Calculate(int multiplier, int multiplicand)
        {
            return multiplier * multiplicand;
        }

        public string GetCalculationString(int multiplier, int multiplicand)
        {
            return $"{multiplier} * {multiplicand} = {Calculate(multiplier, multiplicand)}";
        }
    }
}