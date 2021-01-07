namespace SOLID.Operations
{
    public class AddOperation : IOperation
    {
        private const string OperationName = "Summation";
        public string GetOperationName()
        {
            return OperationName;
        }
        
        public int Calculate(int addend1, int addend2)
        {
            return addend1 + addend2;
        }

        public string GetCalculationString(int addend1, int addend2)
        {
            return $"{addend1} + {addend2} = {Calculate(addend1, addend2)}";
        }
    }
}
