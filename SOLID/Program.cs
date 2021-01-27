using System.Collections.Generic;
using System.Globalization;

namespace SOLID
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var commandReader = new ConsoleCommandReader();
            var commandChar = commandReader.Read();

            var numberReader = new ConsoleNumberReader();
            var operands = new List<float> {numberReader.Read(), numberReader.Read()};

            var factory = new ArithmeticOperationFactory(operands.Count);
            IArithmeticOperation mathOperation = factory.Create(commandChar);

            var basicCalculator = new BasicCalculator();
            var result = basicCalculator.Calculate(operands, mathOperation);

            var outputWriter = new ConsoleOutputWriter();
            outputWriter.Write(result.ToString(CultureInfo.InvariantCulture));

            var logger = new FileLogger("log.json");
            logger.Log(result.ToString(CultureInfo.InvariantCulture));
        }
    }
}
