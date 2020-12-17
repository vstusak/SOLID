using System.IO;

namespace SOLID
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var logger = new HistoryFileLogger();
            var calculator = new BaseCalculator();
            var result = calculator.Calculate();

            logger.LogHistory($"Result: {result}");
        }
    }
}
