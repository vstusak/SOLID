using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorApiHandler : ICalculatorApiHandler
    {
        private readonly ICalculatorCore _calculatorCore;

        public CalculatorApiHandler(ICalculatorCore calculatorCore)
        {
            _calculatorCore = calculatorCore;

        }

        public double Execute(InputData inputData)
        {
            double result;
            switch (inputData.Operation)
            {
                case OperationEnum.Undefined:
                    throw new InvalidOperationException();
                    break;
                case OperationEnum.Add:
                    result = _calculatorCore.Add(inputData.Value1, inputData.Value2);
                    break;
                case OperationEnum.Sub:
                    result = _calculatorCore.Sub(inputData.Value1, inputData.Value2);
                    break;
                case OperationEnum.Mult:
                    result = _calculatorCore.Mult(inputData.Value1, inputData.Value2);
                    break;
                case OperationEnum.Div:
                    result = _calculatorCore.Div(inputData.Value1, inputData.Value2);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }
    }
}
