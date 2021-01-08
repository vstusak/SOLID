using SOLID.InputOutput;
using SOLID.Util;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            var logger = new Logger();
            var output = new ConsoleOutput();
            var valueGetter = new ValueGetter();
            var operationFactory = new OperationFactory();
            var calculator = new Calculator(valueGetter,operationFactory,logger,output);
            calculator.RunCalculator();
            do
            {
            } while (calculator.RunCalculator());
        }
    }
}
