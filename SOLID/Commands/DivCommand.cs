using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Commands
{
    class DivCommand : ICommand
    {
        public char CommandName => '/';
        public int NumberOfParameters => 2;

        public double Calculate(IEnumerable<double> Parameters, out string DecoratedOutput)
        {
            var operands = Parameters.ToList();
            var result = operands[0] / operands[1];
            DecoratedOutput = $"{operands[0]} / {operands[1]} = {result}";
            return result;
        }
    }
}
