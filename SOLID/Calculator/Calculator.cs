using System;
using System.Linq;
using System.Collections.Generic;
using SOLID.Commands;
using SOLID.DataReaders;
using SOLID.DataWriters;
using SOLID.Logger;

namespace SOLID
{
    class Calculator : ICalculator
    {
        private IDataReader _dataReader;
        private IDataWriter _dataWriter;
        private IEnumerable<ICommand> _supportedCommands;
        private ILogger _logger;

        public Calculator(ILogger Logger)
        {
            _logger = Logger;
        }

        public Calculator(IDataReader DataReader, IDataWriter DataWriter, IEnumerable<ICommand> SupportedCommands, ILogger Logger)
        {
            _dataReader = DataReader;
            _dataWriter = DataWriter;
            _supportedCommands = SupportedCommands;
            _logger = Logger;
        }

        public void SetDataReader(IDataReader DataReader)
        {
            _dataReader = DataReader;
        }

        public void SetDataWriter(IDataWriter DataWriter)
        {
            _dataWriter = DataWriter;
        }

        public void SetSupportedCommands(IEnumerable<ICommand> SupportedCommands)
        {
            _supportedCommands = SupportedCommands;
        }

        public void Calculate()
        {
            try
            {
                var commandName = _dataReader.ReadCommandName(ListOfCommandNames());

                _logger.Log($"Read a command name: '{commandName}'");

                var command = GetCommandByName(commandName);

                _logger.Log($"Found a command '{command.CommandName}' accepting {command.NumberOfParameters} parameter(s)");

                var commandParameters = _dataReader.ReadParameters(command.NumberOfParameters);

                _logger.Log($"Read {commandParameters.Count()} parameter(s)");

                var calculatedResult = command.Calculate(commandParameters, out var decoratedOutput);

                _logger.Log($"'{command.CommandName}' command has been executed");
                _logger.Log($"Calculated result: {calculatedResult}");
                _logger.Log($"Decorated result: {decoratedOutput}");

                _dataWriter.WriteRawResult(calculatedResult);
                _dataWriter.WriteDecorated(decoratedOutput);
            } 
            catch (Exception e)
            {
                _logger.Log($"Error: {e.Message}");
                throw e;
            }
        }

        private ICommand GetCommandByName(char Name)
        {
            try
            {
                return _supportedCommands.First(c => c.CommandName == Name);
            }
            catch (Exception)
            {
                throw new ArgumentException($"Command '{Name}' not found");
            }
        }

        private string ListOfCommandNames() => string.Join(",", _supportedCommands.Select(c => c.CommandName));

    }
}
