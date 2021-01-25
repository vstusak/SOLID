using System.Collections.Generic;
using SOLID.Commands;
using SOLID.DataReaders;
using SOLID.DataWriters;

namespace SOLID
{
    class CalculatorAdvanced : CalculatorBase
    {
        public CalculatorAdvanced(IDataReader DataReader, IDataWriter DataWriter)
        {
            base.SetDataReader(DataReader);
            base.SetDataWriter(DataWriter);
            base.SetSupportedCommands(
                new List<ICommand>
                {
                    new AddCommand(),
                    new SubCommand(),
                    new MulCommand(),
                    new DivCommand(),
                    new PowerCommand(),
                    new SqrtCommand()
                });
        }
    }
}
