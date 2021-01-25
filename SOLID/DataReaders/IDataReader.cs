using System.Collections.Generic;

namespace SOLID.DataReaders
{
    interface IDataReader
    {
        char ReadCommandName();
        char ReadCommandName(string HintText);
        IEnumerable<double> ReadParameters(int NumberOfParameters);
    }
}
