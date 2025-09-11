using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Facilitates interaction with console.
    /// Provides - reading from and writing to.
    /// (used to have a switch that called specific operation from CalculatorCore)
    /// now the input is read from console and passed as an object to CalculatorCOre
    /// </summary>
    public class CalculatorConsoleHandler
    {
        private readonly IConsoleDataReader _reader;
        private readonly IConsoleDataWriter _writer;
        private readonly ICalculatorCore _calculatorCore;

        public CalculatorConsoleHandler(IConsoleDataReader reader, IConsoleDataWriter writer, ICalculatorCore calculatorCore)
        {
            _reader = reader;
            _writer = writer;
            _calculatorCore = calculatorCore;
        }

        public double Execute()
        {
            _writer.WriteMessage("Fill the operator in:");
            var operatorIdentifier = _reader.ReadOperator();

            _writer.WriteMessage("Fill the first value in:");
            var value1 = _reader.ReadValue();

            _writer.WriteMessage("Fill the second value in:");
            var value2 = _reader.ReadValue();
            
            var inputData = new InputData(value1, value2, operatorIdentifier);
            
            var result = _calculatorCore.ProcessInput(inputData);
            _writer.WriteValue(result);
            return result;
        }
    }
}
