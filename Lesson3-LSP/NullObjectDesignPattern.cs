using System;

namespace Lesson3_LSP
{
    class NullObjectDesignPattern
    {
        public void DoSomething()
        {
            var factory = new CalculatorFactory();
            var calculator = factory.Create("kids");

            var result = calculator.Calculate();
            Console.WriteLine($"Result: [{result}]");            
        }
    }

    internal class CalculatorFactory    
    {
        public Calculator Create(string type)
        {
            switch (type)
            {
                case "standard":
                    return new Calculator();
                case "science":
                    return new ScienceCalculator();
                default:
                    return new UnknownCalculator(type);
            }
        }
    }

    public class UnknownCalculator : Calculator
    {
        private string _message;

        public UnknownCalculator(string message)
        {
            _message = message;
        }
        public override int Calculate()
        {
            Console.WriteLine($"Input type [{_message}] not recognized.");
            //Good place for error log information
            return -1; //Better to return an exception
        }
    }

    public class ScienceCalculator : Calculator
    {
        public override int Calculate()
        {
            return 0;
        }
    }

    public class Calculator : object
    {
        public virtual int Calculate()
        {
            return 1;
        }
    }
}
