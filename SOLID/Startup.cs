using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Communication;
using SOLID.Factories;
using SOLID.Logger;
using SOLID.Providers;

namespace SOLID
{
    public class Startup
    {
        private readonly ICalculatorProvider _calculatorProvider;
        private readonly ILogger _logger;
        private readonly IMessageProvider _userMessage;
        private readonly ICommunication _communication;
        private readonly ICalculationStrategyFactory _strategyFactory;

        public Startup(ICalculatorProvider calculatorProvider,
            ILogger logger,
            IMessageProvider userMessage,
            ICommunication communication,
            ICalculationStrategyFactory strategyFactory)
        {
            _calculatorProvider = calculatorProvider;
            _logger = logger;
            _userMessage = userMessage;
            _communication = communication;
            _strategyFactory = strategyFactory;
        }

        public void Run()
        {
            // exception handling
            // option to calculate again and not end

            _userMessage.ShowMessageToUser("Calculator started.");
            var operand = _communication.CollectUsersOperand();
            _strategyFactory.Set(operand);

            var input = _communication.CollectUsersInputValues();
            var output = _calculatorProvider.Calculate(input);
            _userMessage.ShowMessageToUser(
                $"Result of {operand} for {input.FirstNumber} and {input.SecondNumber} is {output}");

            _logger.LogHistory($"Result at {DateTimeOffset.UtcNow} is {output}.");
        }
    }
}
