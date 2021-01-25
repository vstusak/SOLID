using System;

namespace SOLID.DataWriters
{
    class StringDataWriter : IDataWriter
    {
        private double _rawResult;
        private string _decoratedOutput;

        public void WriteRawResult(double Result)
        {
            _rawResult = Result;
        }

        public void WriteDecorated(string DecoratedOutput)
        {
            _decoratedOutput = DecoratedOutput;
        }

        public override string ToString()
        {
            return _rawResult.ToString();
        }
        public string ToStringDecorated()
        {
            return _decoratedOutput;
        }
    }
}
