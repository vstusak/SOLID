namespace SOLID.Operations
{
    public class SubOperation : IOperation
    {
        private const string OperationName = "Subtraction";
        public string GetOperationName()
        {
            return OperationName;
        }
        
        public int Calculate(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public string GetCalculationString(int minuend, int subtrahend)
        {
            return $"{minuend} - {subtrahend} = {Calculate(minuend, subtrahend)}";
        }
    }
}