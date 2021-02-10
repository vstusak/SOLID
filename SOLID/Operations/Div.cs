namespace SOLID.Operations
{
    public class Div
    {
        public int Result;

        public Div((int, int) numbers)
        {
            Result = CalculateResult(numbers);
        }

        public int CalculateResult((int, int) numbers)
        {
            return numbers.Item1 / numbers.Item2;
        }
    }
}