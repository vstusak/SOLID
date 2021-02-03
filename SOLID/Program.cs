using SOLID.InputOutput;
using SOLID.Util;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            Output output = new Output();
            GetOperand valueGetter = new GetOperand();
            OperatorFactory operatorFactory = new OperatorFactory();
            Calc calculator = new Calc(valueGetter, operatorFactory, output);
            calculator.RunCalculator();
        }
    }
}
