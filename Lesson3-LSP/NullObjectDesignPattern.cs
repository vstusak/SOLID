using System;

namespace Lesson3_LSP
{
    class NullObjectDesignPattern
    {
        public void DoSomething()
        {
            //var factory = new CalculatorFactory();
            //var calculator = factory.Create("kids");

            Calculator calculator;
            var calculatorType = "kids";

            switch (calculatorType)
            {
                case "standard":
                    calculator = new Calculator();
                    break;
                case "science":
                    calculator = new ScienceCalculator();
                    break;
                default:
                    calculator = new NullCalculator(calculatorType);
                    break;
            }


            //var result = calculator?.Calculate();
            //Console.WriteLine(result);
            //if (calculator != null)
            //{
            //    var result = calculator.Calculate();
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Calculator failed to load.");
            //}

            var result = calculator.Calculate();
            Console.WriteLine(result);
        }
    }

    public class CalculatorFactory    
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

    public class NullCalculator : Calculator
    {
        private string type;

        public NullCalculator(string type)
        {
            this.type = type;
        }

        public override int Calculate()
        {
            Console.WriteLine($"You find yourself in a NullCalculator. You have a type \"{type}\" defined.");
            throw new Exception("Unknown calc defined.");
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
