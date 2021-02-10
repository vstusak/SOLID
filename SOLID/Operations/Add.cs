namespace SOLID.Operations
{
    public class Add
    {
        public int Result;

        public Add((int, int) numbers)
        {
            Result = CalculateResult(numbers);
        }

        public int CalculateResult((int, int) numbers)
        {
            return numbers.Item1 + numbers.Item2;
        }
    }
}