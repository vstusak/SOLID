using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    public class ConsoleAdapter : IConsoleAdapter
    {
        public string ReadLine()
        {
            var line = Console.ReadLine() ?? String.Empty;

            return line;


            //Slouzi jako priklad - zapis shodny se zapisem o radek vyse
            var line2 = Console.ReadLine();
            return line2 == null ? string.Empty : line2;

            var line3 = Console.ReadLine();

            if (line3 == null)
            {
                return String.Empty;
            }
            else
            {
                return line3;
            }
        }

        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}
