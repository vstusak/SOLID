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
            var result = _calculatorCore.ProcessInput(inputData);
            return result;
        }

    }
}
