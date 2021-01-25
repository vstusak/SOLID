using SOLID.Commands;
using System.Collections.Generic;

namespace SOLID.DataWriters
{
    interface IDataWriter
    {
        void WriteRawResult(double Result);
        void WriteDecorated(string DecoratedOutput);
        string ToString();
        string ToStringDecorated();
    }
}
