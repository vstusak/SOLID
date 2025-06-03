using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ConsoleDataWriter : IConsoleDataWriter
    {
        private readonly IConsoleAdapter _consoleAdapter;

        public ConsoleDataWriter(IConsoleAdapter consoleAdapter)
        {
            _consoleAdapter = consoleAdapter;

        }

        public void WriteValue(double value)
        {
            _consoleAdapter.WriteLine("Result is: " + value.ToString());
        }
    }

    public interface IConsoleAdapter
    {
        string ReadLine();
        void WriteLine(string value);
    }

    public interface IConsoleDataWriter
    {
        void WriteValue(double value);
        void WriteMessage(string empty);
    }
}
