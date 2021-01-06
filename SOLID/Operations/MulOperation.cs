namespace SOLID.Operations
{
    public class MulOperation : IOperation
    {
        public int Calculate(int value1, int value2)
        {
            return value1 * value2;
        }

        public string GetCalculationString(int value1, int value2)
        {
            return $"{value1} * {value2} = {Calculate(value1, value2)}";
        }
    }
}