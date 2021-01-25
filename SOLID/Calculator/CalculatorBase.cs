using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SOLID.Commands;
using SOLID.DataReaders;
using SOLID.DataWriters;

namespace SOLID
{
    class CalculatorBase
    {
        private IDataReader _dataReader;
        private IDataWriter _dataWriter;
        private IEnumerable<ICommand> _supportedCommands;

        public void SetDataReader(IDataReader DataReader)
        {
            _dataReader = DataReader;
        }

        public void SetDataWriter(IDataWriter DataWriter)
        {
            _dataWriter = DataWriter;
        }

        public void SetSupportedCommands(IEnumerable<ICommand> supportedCommands)
        {
            _supportedCommands = supportedCommands;
        }

        public double Calculate()
        {
            var commandName = _dataReader.ReadCommandName(string.Join(",", _supportedCommands.Select(c => c.CommandName)));

            var command = _supportedCommands.FirstOrDefault(c => c.CommandName == commandName);
            if (command == null)
            {
                throw new ArgumentException($"Command '{commandName}' not found.");
            }

            var parameters = _dataReader.ReadParameters(command.NumberOfParameters);
            if (parameters.Count() != command.NumberOfParameters)
            {
                throw new ArgumentException($"Incorrect number of parameters. Command '{commandName}' has {command.NumberOfParameters} parameters");
            }

            var calculatedResult = command.Calculate(parameters, out var decoratedOutput);

            _dataWriter.WriteRawResult(calculatedResult);
            _dataWriter.WriteDecorated(decoratedOutput);

            return calculatedResult;
        }
    }
}
