namespace SOLID.Operations
{
    internal class Sub
    {
        public int Result;

        public Sub((int, int) numbers)
        {
            Result = CalculateResult(numbers);
        }

        public int CalculateResult((int, int) numbers)
        {
            return numbers.Item1 - numbers.Item2;
        }
    }
}