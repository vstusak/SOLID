using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public OperationEnum ReadOperator()
        {
            throw new NotImplementedException();
        }
    }
    public interface IConsoleDataReader
    {
        int ReadValue();
        OperationEnum ReadOperator();
    }
}
