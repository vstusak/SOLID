﻿using SOLID.Helpers.ConsoleOperations;
using SOLID.Utils;

namespace SOLID.Operations
{
    internal class Addition : IOperation
    {
        private static ConsoleOutput output = new ConsoleOutput();
        private static Logger _logger = new Logger();
        
        public int Calculate(int number1, int number2)
        {
            return number1 + number2;
        }

        public void ReturnResult(int number1, int number2)
        {
            output.Print($"{number1} + {number2} = {Calculate(number1, number2)}");
            _logger.LogHistory("");
        }
    }
}
