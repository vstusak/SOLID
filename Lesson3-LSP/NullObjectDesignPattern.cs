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
            Console.WriteLine(result);
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
                    return new NullCalculator(type);
            }
        }
    }

    public class ScienceCalculator : Calculator
    {
        public override int Calculate()
        {
            return 0;
        }
    }

    public class Calculator
    {
        public virtual int Calculate()
        {
            return 1;
        }
    }

    public class NullCalculator : Calculator
    {
        private readonly string _calculator;
        public NullCalculator(string calculator)
        {
            _calculator = calculator;
        }

        public override int Calculate()
        {
            throw new ArgumentException($"Calculator has not been created. Requested type of calculator was: {_calculator}. ");
        }
    }
}