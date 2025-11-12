using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Calculator.Contracts;

[assembly: InternalsVisibleTo("Calculator.Tests")]

namespace Calculator
{
    /// <summary>
    /// Core provides core calculator functionality => operations (add, sub, mult, div).
    /// Used to have only methods for operations (add, sub..) that were called directly by handlers.
    /// Now contains switch in "ProcessInput" method, that is called by both Handlers.
    /// </summary>

    public class CalculatorCore : ICalculatorCore
    {
        internal double Add(int value1, int value2)
        {
            return value1 + value2;
        }

        internal double Sub(int value1, int value2)
        {
            return value1 - value2;
        }

        internal double Mult(int value1, int value2)
        {
            return value1 * value2;
        }

        internal double Div(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new DivideByZeroException($"You are trying divide {value1} by 0.");
            }

            return value1 / value2;
        }

        public double ProcessInput(InputData inputData)
        {
            double result;
            switch (inputData.Operation)
            {
                case OperationEnum.Undefined:
                    throw new InvalidOperationException();
                    break;
                case OperationEnum.Add:
                    result = Add(inputData.Value1, inputData.Value2);
                    break;
                case OperationEnum.Sub:
                    result = Sub(inputData.Value1, inputData.Value2);
                    break;
                case OperationEnum.Mult:
                    result = Mult(inputData.Value1, inputData.Value2);
                    break;
                case OperationEnum.Div:
                    result = Div(inputData.Value1, inputData.Value2);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }
    }
    public interface ICalculatorCore
    {
     //commented out because of change to private
        //double Add(int value1, int value2);
        //double Sub(int value1, int value2);
        //double Mult(int value1, int value2);
        //double Div(double value1, double value2);
        double ProcessInput(InputData inputData);
    }
    //TODO: use TDD where is possible
    //TODO: Add asp net core web project (razor pages) and create UI and call API backend
            //TODO: Add button for calculator in a layout
            //TODO: Create razor page for calculator
            //TODO: Create service to call API backend get calculator result
    //TODO: Add asp net core web project (blazor pages) and create UI and call API backend
    //TODO: Run all of 3 projects (API, RAZOR, BLAZOR) together and try it out
    //TODO: Introduce microsoft aspire for project above
    //TODO: refactor to use description to enum. (use operator)
}
