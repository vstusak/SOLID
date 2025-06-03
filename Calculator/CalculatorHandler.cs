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
            _writer.WriteMessage("");
            var operatorIdentifier = _reader.ReadOperator();
            
            var value1 = _reader.ReadValue();
            var value2 = _reader.ReadValue();
            
            double result;
            switch (operatorIdentifier)
            {
                case OperationEnum.Undefined:
                    throw new InvalidOperationException();
                    break;
                case OperationEnum.Add:
                    result = _calculatorCoreCore.Add(value1, value2);
                    break;
                case OperationEnum.Sub:
                    result = _calculatorCoreCore.Sub(value1, value2);
                    break;
                case OperationEnum.Mult:
                    result = _calculatorCoreCore.Mult(value1, value2);
                    break;
                case OperationEnum.Div: 
                    result = _calculatorCoreCore.Div(value1, value2);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            _writer.WriteValue(result);
            return result;
        }
    }
}
