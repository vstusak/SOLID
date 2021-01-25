using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DataReaders
{
    class ConsoleDataReader : IDataReader
    {
        public char ReadCommandName() => ReadCommandName("");

        public char ReadCommandName(string HintText)
        {
            Console.Write($"Set command{(!string.IsNullOrWhiteSpace(HintText) ? " (" + HintText + ")" : "")}:");
            return Console.ReadKey().KeyChar;
        }

        public IEnumerable<double> ReadParameters(int NumberOfParameters)
        {
            List<double> result = new List<double>();
            for (var i = 1; i <= NumberOfParameters; i++)
            {
                Console.Write($"{(i==1?"\n":"")}Set value {i}:");
                var readData = Console.ReadLine();
                if (double.TryParse(readData, out double data))
                {
                    result.Add(data);
                }    
                else
                {
                    result.Add(0);
                    Console.WriteLine("Incorrect number format. Used zero as a value.");
                }
            }
            return result;
        }
    }
}
