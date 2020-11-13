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
            //TODO argument null check
            return type switch
            {
                "standard" => new Calculator(),
                "science" => new ScienceCalculator(),
                _ => new NullCalculator()
            };
        }
    }

    internal class NullCalculator : Calculator
    {
        public override int Calculate()
        {
            throw new Exception("This is non-generic NULL!");
        }
    }

    public class ScienceCalculator : Calculator
    {
        public override int Calculate()
        {
            return 42;
        }
    }

    public class Calculator
    {
        public virtual int Calculate()
        {
            return 69;
        }
    }
}
