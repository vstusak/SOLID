using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorHandler
    {
        private readonly ConsoleDataReader _reader;
        private readonly ConsoleDataWriter _writer;
        private readonly TddCalculator _calculatorCore;

        public CalculatorHandler(ConsoleDataReader reader, ConsoleDataWriter writer, TddCalculator calculatorCore)
        {
            _reader = reader;
            _writer = writer;
            _calculatorCore = calculatorCore;
        }

        public double Execute()
        {
            throw new NotImplementedException();
        }
    }
}
