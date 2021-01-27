using System.Collections.Generic;
using SOLID.Commands;
using SOLID.DataReaders;
using SOLID.DataWriters;
using SOLID.Logger;

namespace SOLID
{
    class CalculatorSimple : Calculator
    {
        public CalculatorSimple(IDataReader DataReader, IDataWriter DataWriter, ILogger Logger) : base(Logger)
        {
            SetDataReader(DataReader);
            SetDataWriter(DataWriter);
            SetSupportedCommands(
                new List<ICommand>
                {
                    new AddCommand(),
                    new SubCommand(),
                    new MulCommand(),
                    new DivCommand()
                });
        }
    }
}
