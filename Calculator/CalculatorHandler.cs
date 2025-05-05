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
                    return result;
                case OperationEnum.Sub:
                    result = _calculatorCoreCore.Sub(value1, value2);
                    return result;
                case OperationEnum.Mult:
                    result = _calculatorCoreCore.Mult(value1, value2);
                    return result;
                case OperationEnum.Div: // TODO div not passing in test
                    result = _calculatorCoreCore.Div(value1, value2);
                    return result; 
                default:
                    throw new ArgumentOutOfRangeException();
            }

            //TODO output result to console via writer
            
            return result;
        }
    }
}
