using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
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
        static void Main(string[] args)
        {
            //var value1 = ValueGetter1();
            //var value2 = ValueGetter2();
            var valueGetter = new ValueGetter();
            var value1class = valueGetter.GetValue1();
            var value2class = valueGetter.GetValue2();
            var methodInputterClass = new MethodInputter();
            var calculationMethodClass = new CalculationMethodSelectorClass(methodInputterClass);
            var calculatorClass = new Calculator(calculationMethodClass.SelectCalulationMethod(), value1class, value2class);
            //var calculator = new Calculator(CalculationMethodSelector(InputCalculationMethod(out ConsoleKeyInfo key)));
            //calculator.Calculate(value1, value2);
            calculatorClass.Calculate();
            //var resultsManager = new ResultsManager(calculator);
            //resultsManager.ManageResults();
        }

        public class CalculationMethodSelectorClass
        {
            private readonly MethodInputter _methodInputter;
            public CalculationMethodSelectorClass(MethodInputter methodInputter)
            {
                _methodInputter = methodInputter;
            }

            public ICalculatorMethodProvider SelectCalulationMethod()
            {
             
                switch (_methodInputter.InputCalculationMethod(out ConsoleKeyInfo key))
                {

                    case '+':
                        var add = new CalculatorMethodProviderAdd();
                        return add;
                    case '-':
                        var sub = new CalculatorMethodProviderSub();
                        return sub;
                    case '*':
                        var mul = new CalculatorMethodProviderMul();
                        return mul;
                    case '/':
                        var div = new CalculatorMethodProviderDiv();
                        return div;
                    default:
                        Console.WriteLine("Not supported");
                        return null;
                }
            }
        }
        public static ICalculatorMethodProvider CalculationMethodSelector(char keychar)
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
                    var mul = new CalculatorMethodProviderMul();
                    return mul;
                case '/':
                    var div = new CalculatorMethodProviderDiv();
                    return div;
                default:
                    Console.WriteLine("Not supported");
                    return null;
            }
        }

        public class MethodInputter

        {
            public MethodInputter()
            {
            }
            public char InputCalculationMethod(out ConsoleKeyInfo key)
            {
                Console.WriteLine("Set Command (+. -, *, /)");
                key = Console.ReadKey();
                return key.KeyChar;
            }
        }
        private static char InputCalculationMethod(out ConsoleKeyInfo key)
        {
            Console.WriteLine("Set Command (+. -, *, /)");
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
                var resultMessage = $"\n{value1} + {value2} = {result}";
                Console.WriteLine(resultMessage);
                return resultMessage;
            }
        }
        public class CalculatorMethodProviderSub : ICalculatorMethodProvider
        {
            //private readonly ICalculatorMethodProvider _calculatorMethodProvider;
            //public CalculatorMethodProviderSub(ICalculatorMethodProvider calculatorMethodProvider)
            //{
            //    _calculatorMethodProvider = calculatorMethodProvider;
            //}
            public string Process(int value1, int value2)
            {
                var result = value1 - value2;
                var resultMessage = $"\n{value1} - {value2} = {result}";
                Console.WriteLine(resultMessage);
                return resultMessage;
            }
        }
        public class CalculatorMethodProviderMul : ICalculatorMethodProvider
        {
            public string Process(int value1, int value2)
            {
                var result = value1 * value2;
                var resultMessage = $"\n {value1} * {value2} = {result}";
                Console.WriteLine(resultMessage);
                return resultMessage;
            }
        }
        public class CalculatorMethodProviderDiv : ICalculatorMethodProvider
        {
            public string Process(int value1, int value2)
            {
                var result = value1 / value2;
                var resultMessage = $"\n {value1} / {value2} = {result}";
                Console.WriteLine(resultMessage);
                return resultMessage;
            }
        }

        public class Calculator
        {
            private readonly ICalculatorMethodProvider _calculatorMethodProvider;
            private readonly int _value1;
            private readonly int _value2;
            public Calculator(ICalculatorMethodProvider calculatorMethodProvider, int value1, int value2)
            {
                _calculatorMethodProvider = calculatorMethodProvider;
                _value1 = value1;
                _value2 = value2;
            }

            public string Calculate()
            {
                var result = _calculatorMethodProvider.Process(_value1, _value2).ToString();
                return result;

            }
        }

        public class ResultsManager
        {
            private readonly Calculator _calculator;
            public ResultsManager(Calculator calculator)
            {
                _calculator = calculator;
            }

            public void ManageResults()
            {
                //var resultMessage = _calculator.Calculate()
                Console.WriteLine(_calculator);
                File.AppendAllText("salaries.json", $"{DateTime.UtcNow} : {_calculator}\n");
            }
        }

        public class ValueGetter
        {
            public ValueGetter()
            {
            }
            public int GetValue1()
            {
                Console.WriteLine("set value 1");
                var value2 = int.Parse(Console.ReadLine());
                return value2;
            }
            public int GetValue2()
            {
                Console.WriteLine("set value 2");
                var value2 = int.Parse(Console.ReadLine());
                return value2;
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
            Console.WriteLine("set value 1");
            var value1 = int.Parse(Console.ReadLine());
            return value1;
        }

    }
}
