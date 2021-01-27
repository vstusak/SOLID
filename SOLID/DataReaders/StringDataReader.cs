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

        public char ReadCommandName(string AvailableCommandNames)
        {
            if (_data.Length > 0)
            {
                return _data[0];
            }
            return ' ';
        }

        public IEnumerable<double> ReadParameters(int AcceptedNumberOfParameters)
        {
            List<double> result = new List<double>();
            string[] cmd = _data.Split(' ');
            if (cmd.Length == AcceptedNumberOfParameters + 1)
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
                    }
                }
            }
            else
            {
                throw new ArgumentException($"Incorrect number of parameters. Expected {AcceptedNumberOfParameters} but found {cmd.Length - 1} in string '{_data}'");
            }
            return result;
        }
    }
}
