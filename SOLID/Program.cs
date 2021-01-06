using System;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            while (true)
            {
                try
                {
                    var logger = new Logger();
                    var operationDecider = new OperationDecider();
                    var operation = operationDecider.PromptForOperation();
                    var valueGetter = new ValueGetter();

                    var value1 = valueGetter.PromptForValue();
                    var value2 = valueGetter.PromptForValue();
                    var output = operation.GetCalculationString(value1, value2);
                    Console.WriteLine(output);
                    logger.Log(output);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception occurred: {e.Message}");
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
