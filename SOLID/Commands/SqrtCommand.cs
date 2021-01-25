using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Commands
{
    class SqrtCommand : ICommand
    {
        public char CommandName => 's';
        public int NumberOfParameters => 1;

        public double Calculate(IEnumerable<double> Parameters, out string DecoratedOutput)
        {
            var operands = Parameters.ToList();
            var result = Math.Sqrt(operands[0]);
            DecoratedOutput = $"√ {operands[0]} = {result}";
            return result;
        }
    }
}
