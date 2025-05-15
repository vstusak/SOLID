using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ConsoleDataWriter : IConsoleDataWriter
    {
        public void WriteValue(double value)
        {
            throw new NotImplementedException();
        }
    }
    public interface IConsoleDataWriter
    {
        void WriteValue(double value);
    }
}
