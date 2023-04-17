using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IReader
    {
        string ReadCommand();
        double ReadValue();
    }

    public class lineReader : IReader
    {
        public string ReadCommand()
        {
            Console.WriteLine("Write operation (+. -, *, /)");
            return Console.ReadLine();
        }

        public double ReadValue()
        {
            Console.WriteLine("Write numeric value.");
            var value = Console.ReadLine();
            return double.Parse(value);
        }
    }
}
