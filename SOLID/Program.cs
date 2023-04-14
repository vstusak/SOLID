using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace SOLID
{
    //call new object Calculator -> method Calculate
    //method calculate should return Result
    //5-7 rows
    //only Main in class Program
    class Program
    {
        void Main(string[] args)
        {
            var value1 = ValueGetter1();
            var value2 = ValueGetter2();
            var calculator = new Calculator(CalculationMethodSelector(InputCalculationMethod(out ConsoleKeyInfo key)));
            calculator.Calculate(value1, value2);
        }

        public ICalculatorMethodProvider CalculationMethodSelector(char keychar)
        {
       
            switch (keychar)
            {
               
                case '+':
                    var add = new CalculatorMethodProviderAdd();
                    return add;
                case '-':
                    var sub = new CalculatorMethodProviderSub();
                    return sub;
                case '*':
                    var mul = new CalculatorMethodProviderDiv();
                    return mul;
                case '/':
                    var div = new CalculatorMethodProviderDiv();
                    return div;
                default:
                    Console.WriteLine("Not supported");
                    return null;
            }
        }

       private static char InputCalculationMethod(out ConsoleKeyInfo key)
        {
            Console.WriteLine("Set Command (+. -, *, /");
            key = Console.ReadKey();
            return key.KeyChar;
        }


        public interface ICalculatorMethodProvider
        {
            string Process(int value1, int value2);
        }

        public class CalculatorMethodProviderAdd : ICalculatorMethodProvider
        {
            public string Process(int value1, int value2)
            {
                var result = value1 + value2;
                var resultMessage = $"{value1} + {value2} = {result}";
                return resultMessage;
            }
        }
        public class CalculatorMethodProviderSub : ICalculatorMethodProvider
        {
            public string Process(int value1, int value2)
            {
                var result = value1 - value2;
                var resultMessage = $"{value1} - {value2} = {result}";
                return resultMessage;
            }
        }
        public class CalculatorMethodProviderMul : ICalculatorMethodProvider
        {
            public string Process(int value1, int value2)
            {
                var result = value1 * value2;
                var resultMessage = $"{value1} * {value2} = {result}";
                return resultMessage;
            }
        }
        public class CalculatorMethodProviderDiv : ICalculatorMethodProvider
        {
            public string Process(int value1, int value2)
            {
                var result = value1 / value2;
                var resultMessage = $"{value1} / {value2} = {result}";
                return resultMessage;
            }
        }

        public class Calculator
        {
            private readonly ICalculatorMethodProvider _calculatorMethodProvider;
            public Calculator(ICalculatorMethodProvider calculatorMethodProvider)
            {
                _calculatorMethodProvider = calculatorMethodProvider;
            }

            public void Calculate(int value1, int value2)
            {
                _calculatorMethodProvider.Process(value1, value2);
            }
        }
        //public class RetirementCalculator
        //{
        //    private readonly IRetirementRulesProvider _rulesProvider;
        //    public RetirementCalculator(IRetirementRulesProvider rulesProvider)
        //    {
        //        _rulesProvider = rulesProvider;
        //    }

        //    public int Process(List<Salary> salaries, int baseRetirementSalary)
        //    {
        //        var multiplication = _rulesProvider.GetMultiplication(salaries);
        //        var bonusSum = _rulesProvider.GetBonuses(salaries);

        //        return Convert.ToInt32(baseRetirementSalary * multiplication + bonusSum);
        //    }
        //}
        public class ResultsManager
        {
                private readonly ICalculatorMethodProvider _calculatorMethodProvider;
            public ResultsManager(ICalculatorMethodProvider calculatorMethodProvider)
            {
                _calculatorMethodProvider = calculatorMethodProvider;
            }

            public void WriteResult(string output)
            {
                Console.WriteLine(output);
            }
            public void LogHistory(string _output)
            {
                File.AppendAllText("salaries.json", $"{DateTime.UtcNow} : {_output}\n");
            }
        }
  
        private static int ValueGetter2()
        {
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());
            return value2;
        }

        private static int ValueGetter1()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            return value1;
        }

    }
}
