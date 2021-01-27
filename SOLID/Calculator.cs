using SOLID.Helpers.ConsoleOperations;
using SOLID.Operations;

namespace SOLID
{
    public class Calculator
    {
        private static ConsoleOutput output = new ConsoleOutput();
        private static ConsoleInput input = new ConsoleInput();

        private (int, int) GetNumbers()
        {
            output.Print("\nset value 1");
            var value1 = input.GetValue();
            
            output.Print("set value 2");
            var value2 = input.GetValue();

            return (value1, value2);
        }

        public void Calculate()
        {
            var operation = input.GetOperation();
            var (number1, number2) = GetNumbers();

            var operationFactory = new OperationFactory();
            var calculation = operationFactory.ChooseOperation(operation);

            calculation.ReturnResult(number1, number2);
        }
    }
}
