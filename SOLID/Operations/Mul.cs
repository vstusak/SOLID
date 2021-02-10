namespace SOLID.Operations
{
    public class Mul
    {
        public int Result;

        public Mul((int, int) numbers)
        {
            Result = CalculateResult(numbers);
        }

        public int CalculateResult((int, int) numbers)
        {
            return numbers.Item1 * numbers.Item2;
        }
    }
}