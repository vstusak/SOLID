using SOLID.Data;
using System;

namespace SOLID.IOActions
{
    public class ConsoleActions : IConsoleActions
    {
        public void GetOperator(InputOutputData inputOutputData, string message)
        {
            Console.WriteLine(message);
            inputOutputData.Operator = Console.ReadKey().KeyChar;
            Console.ReadLine();
        }
        public void GetValues(InputOutputData inputOutputData, string message1, string message2)
        {
            Console.WriteLine(message1);
            inputOutputData.Value1 = float.Parse(Console.ReadLine());
            Console.WriteLine(message2);
            inputOutputData.Value2 = float.Parse(Console.ReadLine());
        }

        public void ReturnResult(InputOutputData inputOutputData)
        {
            var output = $"{inputOutputData.Value1} {inputOutputData.Operator} {inputOutputData.Value2} = {inputOutputData.Output}";
            Console.WriteLine(output);
            Logger.Logger.LogHistory(output);
        }
    }
}
