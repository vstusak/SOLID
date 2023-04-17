using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IReader
    {
        char ReadCommand();
        double ReadValue();
    }

    public class lineReader : IReader
    {
        public char ReadCommand()
        {
            Console.WriteLine("Write operation (+. -, *, /)");
            return Console.ReadKey().KeyChar;
        }

        public double ReadValue()
        {
            Console.WriteLine("\nWrite numeric value.");
            var value = Console.ReadLine();

            if (double.TryParse(value, out double result))
            {
                return result;
            }

            throw new Exception("Input is not a valid number");
        }
    }
}
