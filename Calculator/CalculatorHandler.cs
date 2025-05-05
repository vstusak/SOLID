using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorHandler
    {
        private readonly IConsoleDataReader _reader;
        private readonly IConsoleDataWriter _writer;
        private readonly ICalculatorCore _calculatorCoreCore;

        public CalculatorHandler(IConsoleDataReader reader, IConsoleDataWriter writer, ICalculatorCore calculatorCoreCore)
        {
            _reader = reader;
            _writer = writer;
            _calculatorCoreCore = calculatorCoreCore;
        }

        public double Execute()
        {
            throw new NotImplementedException();
        }
    }
}
