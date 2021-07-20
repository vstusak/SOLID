using System;
using System.IO;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var consoleReader = new ConsoleReader();
                var consoleWriter = new ConsoleWriter();

                consoleWriter.SetValidOperator();

                var @operator = consoleReader.ReadandReturnValidOperator();
                var calculator = new Calculator(@operator);

                consoleWriter.SetValue("1");
                var number1 = consoleReader.ReadAndParseDouble();

                consoleWriter.SetValue("2");
                var number2 = consoleReader.ReadAndParseDouble();

                var result = calculator.Calculate(number1, number2);

                consoleWriter.ShowResult(number1, number2, result, @operator);
            }
            catch (Exception e)
            {

                Console.WriteLine(e); 
            }
           
            //private static void LogHistory(string output)
            //{
            //    File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
            //}
        }
    }
}
