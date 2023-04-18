using System;

namespace SOLID.IO
{
    public class lineReader : IReader
    {
        private IWriter writer;

        public lineReader(IWriter writer)
        {
            this.writer = writer;
        }

        public char ReadCommand()
        {
            writer.Write("Write operation (+. -, *, /)");
            return Console.ReadKey().KeyChar;
        }

        public double ReadValue()
        {
            writer.Write("\nWrite numeric value.");
            var value = Console.ReadLine();

            if (double.TryParse(value, out double result))
            {
                return result;
            }

            throw new Exception("Input is not a valid number");
        }
    }
}
