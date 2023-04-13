using System;
using System.IO;

namespace SOLID
{
    public interface ICalculator
    {
        int Calculate(int value1, int value2);
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class Add : ICalculator
    {
        public int Calculate(int value1, int value2) => value1 + value2;
    }

    public class Sub : ICalculator
    {
        public int Calculate(int value1, int value2) => value1 - value2;
    }

    public class Mul : ICalculator
    {
        public int Calculate(int value1, int value2) => value1 * value2;
    }

    public class Div : ICalculator
    {
        public int Calculate(int value1, int value2) => value1 / value2;
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {message}\n");
        }
    }

    public class CalculatorHandler
    {
        private readonly ILogger _logger;

        public CalculatorHandler(ILogger logger)
        {
            _logger = logger;
        }

        public void Execute(char operation)
        {
            ICalculator calculator = operation switch
            {
                '+' => new Add(),
                '-' => new Sub(),
                '*' => new Mul(),
                '/' => new Div(),
                _ => throw new NotSupportedException("Operation not supported")
            };

            int value1 = ReadIntValue("\nset value 1");
            int value2 = ReadIntValue("set value 2");
            int result = calculator.Calculate(value1, value2);
            string output = $"{value1} {operation} {value2} = {result}";
            _logger.Log(output);
        }

        private int ReadIntValue(string prompt)
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set Command (+, -, *, /):");
            var key = Console.ReadKey();
            var handler = new CalculatorHandler(new ConsoleLogger());
            handler.Execute(key.KeyChar);
        }
    }
}
