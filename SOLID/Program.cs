namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            Calculator calculator = new Calculator();

            var numbers = calculator.ReadNumbers();
            var operation = calculator.ReadOperation();
            var result = calculator.PerformCalculation(numbers, operation);

            calculator.PrintResult(result);
        }
    }
}