using System;

namespace SOLID.DataWriters
{
    class ConsoleDataWriter : IDataWriter
    {
        private double _rawResult;
        private string _decoratedOutput;

        public void WriteRawResult(double Result)
        {
            _rawResult = Result;
            Console.WriteLine(_rawResult.ToString());
        }

        public void WriteDecorated(string DecoratedOutput)
        {
            _decoratedOutput = DecoratedOutput;
            Console.WriteLine(_decoratedOutput);
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
