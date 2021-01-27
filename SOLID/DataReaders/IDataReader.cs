using System.Collections.Generic;

namespace SOLID.DataReaders
{
    interface IDataReader
    {
        char ReadCommandName();
        char ReadCommandName(string AvailableCommandNames);
        IEnumerable<double> ReadParameters(int NumberOfParameters);
    }
}
