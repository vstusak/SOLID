using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DataReaders
{
    class StringDataReader : IDataReader
    {
        private readonly string _data;

        public StringDataReader(string InputString)
        {
            _data = InputString;
        }

        public char ReadCommandName() => ReadCommandName("");

        public char ReadCommandName(string HintText)
        {
            if (_data.Length > 0)
            {
                return _data[0];
            }
            return ' ';
        }

        public IEnumerable<double> ReadParameters(int NumberOfParameters)
        {
            List<double> result = new List<double>();
            string[] cmd = _data.Split(' ');
            if (cmd.Length == NumberOfParameters + 1)
            {
                for (var i = 1; i < cmd.Length; i++)
                {
                    if (double.TryParse(cmd[i], out double data))
                    {
                        result.Add(data);
                    }
                    else
                    {
                        result.Add(0);
                        Console.WriteLine("Incorrect number format ('{_data}'). Used zero as a value.");
                    }
                }
            }
            else
            {
                throw new ArgumentException($"Wrong number of parameters ('{_data}')");
            }
            return result;
        }
    }
}
