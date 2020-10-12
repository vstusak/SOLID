using System;

namespace Lesson3_LSP
{
    class NullObjectDesignPattern
    {
        public void DoSomething()
        {
            var factory = new CalculatorFactory();
            var calculator = factory.Create("kids");

            var result = calculator?.Calculate();
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
                    return null;
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
}
