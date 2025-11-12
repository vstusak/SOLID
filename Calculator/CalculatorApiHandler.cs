using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Contracts;

namespace Calculator
{
    /// Facilitates interaction with api controller. (could also be called Adapter)
    /// Handles data based on specific method requested in controller (decides and forwards where data is sent to be processed)
    /// Decides what operation is called, based on API request data
    /// Sends result back to controller.
    /// Interaction between handler and controller - is not called request-response.
    /// (used to include switch to call specific method from CalculatorCore, same as ConsoleHandler,
    /// Since the switch was duplicated (both in ApiHandler and ConsoleHandler - the switch was moved to CalculatorCore where the decision process is based on input data.
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
