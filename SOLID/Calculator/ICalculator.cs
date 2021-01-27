using SOLID.Commands;
using SOLID.DataReaders;
using SOLID.DataWriters;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    interface ICalculator
    {
        public void SetDataReader(IDataReader DataReader);
        public void SetDataWriter(IDataWriter DataWriter);
        public void SetSupportedCommands(IEnumerable<ICommand> Commands);
        public void Calculate();
    }
}
