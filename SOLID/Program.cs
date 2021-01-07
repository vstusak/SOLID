using SOLID.Logging;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            var logger = new Logger();
            var calculator = new Calculator(logger);
            calculator.RunCalculator();
        }
    }
}
