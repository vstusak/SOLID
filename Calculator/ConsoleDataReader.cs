using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Contracts;

namespace Calculator
{
    public class ConsoleDataReader : IConsoleDataReader
    {
        private readonly IConsoleAdapter _consoleAdapter;

        public ConsoleDataReader(IConsoleAdapter consoleAdapter)
        {
            _consoleAdapter = consoleAdapter;

        }

        public int ReadValue()
        {
            var valueString = _consoleAdapter.ReadLine();
            var result = Convert.ToInt32(valueString);
            return result;
        }

        public OperationEnum ReadOperator()
        {
            //TODO: refactor to use description to enum.
            var valueString = _consoleAdapter.ReadLine();
            switch (valueString)
            {
                case "+":
                    return OperationEnum.Add;
                case "-":
                    return OperationEnum.Sub;
                case "*":
                    return OperationEnum.Mult;
                case "/":
                    return OperationEnum.Div;
                default:
                    throw new ArgumentException();
            }
        }
    }
    public interface IConsoleDataReader
    {
        int ReadValue();
        OperationEnum ReadOperator();
    }
}
