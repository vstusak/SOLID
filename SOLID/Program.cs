using System;
using System.Collections.Generic;
using SOLID.Enums;
using SOLID.InputReader;
using SOLID.Logger;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggers = new List<ILogger>() {new ConsoleLogger(), new FileLogger()};
            var calculator = new Calculator.Calculator(new ConsoleReader(), loggers);

            try
            {
                calculator.Calculate();
            }
            catch (NotSupportedException)
            {
                Environment.Exit(ExitCode.NotSupportedOperation);
            }
            catch (DivideByZeroException)
            {
                Environment.Exit(ExitCode.InvalidArgument);
            }
        }
    }
}
