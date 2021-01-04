using System;
using System.Collections.Generic;
using SOLID.Commands;
using SOLID.Enums;
using SOLID.InputReader;
using SOLID.Logger;

namespace SOLID.Calculator
{
    public class Calculator : ICalculator
    {
        private static IInputReader _inputProvider;
        private readonly IEnumerable<ILogger> _loggers;
        private static ICommand _command;

        public Calculator(IInputReader inputProvider, IEnumerable<ILogger> loggers)
        {
            _inputProvider = inputProvider;
            _loggers = loggers;
        }

        public void Calculate()
        {
            LogHistory(UserMessages.Operations);
            var key = _inputProvider.ReadOperation();

            try
            {
                _command = CommandFactory.GetCommandByKey(key);
            }
            catch (Exception e)
            {
                LogHistory(e);
                throw;
            }

            var (a, b) = GetInputs();

            try
            {
                var result = _command.Execute(a, b);
                LogHistory($"{a} {key} {b} = {result}");
            }
            catch (Exception e)
            {
                LogHistory(e);
                throw;
            }
        }

        private (decimal, decimal) GetInputs()
        {
            LogHistory(UserMessages.FirstValue);
            var firstNumber = decimal.Parse(_inputProvider.ReadValue());
            LogHistory(UserMessages.SecondValue);
            var secondNumber = decimal.Parse(_inputProvider.ReadValue());
            return (firstNumber, secondNumber);
        }

        private void LogHistory(object output)
        {
            foreach (var logger in _loggers) logger.Write(output);
        }
    }
}