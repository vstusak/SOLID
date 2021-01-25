using System;
using System.IO;
using SOLID.DataReaders;
using SOLID.DataWriters;
using SOLID.Logger;

namespace SOLID
{
    class Program
    {
        static FileLogger logger;

        static void Main(string[] args)
        {
            logger = new FileLogger("log.txt");
            SimpleCalc_ConsoleReader();
            //AdvancedCalc_ConsoleReader();
            //AdvancedCalc_StringReader();
        }


        static void SimpleCalc_ConsoleReader()
        {
            try
            {
                ConsoleDataReader consoleDataReader = new ConsoleDataReader();
                ConsoleDataWriter consoleDataWriter = new ConsoleDataWriter();

                CalculatorSimple calcSimple = new CalculatorSimple(consoleDataReader, consoleDataWriter);

                while (true)
                {
                    calcSimple.Calculate();
                    logger.Log(consoleDataWriter.ToStringDecorated());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\n!!! ERROR: {e.Message.Replace("\r", "\\r").Replace("\t", "\\t")}\n");
            }

        }

        static void AdvancedCalc_ConsoleReader()
        {
            try
            {
                ConsoleDataReader consoleDataReader = new ConsoleDataReader();
                ConsoleDataWriter consoleDataWriter = new ConsoleDataWriter();

                CalculatorAdvanced calcAdv = new CalculatorAdvanced(consoleDataReader, consoleDataWriter);

                while (true)
                {
                    calcAdv.Calculate();
                    logger.Log(consoleDataWriter.ToStringDecorated());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\n!!! ERROR: {e.Message.Replace("\r", "\\r").Replace("\t", "\\t")}\n");
            }

        }

        static void AdvancedCalc_StringReader()
        {
            try
            {
                StringDataReader stringDataReader = null;
                StringDataWriter stringDataWriter = new StringDataWriter();

                CalculatorAdvanced calcAdv = new CalculatorAdvanced(stringDataReader, stringDataWriter);

                while (true)
                {
                    Console.Write("Command as a string ('cmd p1 p2 ...'):");
                    calcAdv.SetDataReader(new StringDataReader(Console.ReadLine()));
                    calcAdv.Calculate();
                    Console.WriteLine(stringDataWriter.ToStringDecorated());
                    logger.Log(stringDataWriter.ToStringDecorated());

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\n!!! ERROR: {e.Message.Replace("\r", "\\r").Replace("\t", "\\t")}\n");
            }

        }

        #region Original Code

        static void Main_Original(string[] args)
        {
                Console.WriteLine("Set Command (+. -, *, /)");
            var key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '+':
                    Add();
                    break;
                case '-':
                    Sub();
                    break;
                case '*':
                    Mul();
                    break;
                case '/':
                    Div();
                    break;
                default:
                    Console.WriteLine("Not supported");
                    break;
            }
        }

        private static void Add()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 + value2;

            var output = $"{value1} + {value2} = {result}";
            Console.WriteLine(output);
            LogHistory(output);
        }

        private static void Sub()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 - value2;

            var output = $"{value1} - {value2} = {result}";
            Console.WriteLine(output);
            LogHistory(output);
        }

        private static void Mul()
        {
            throw new NotImplementedException();
        }

        private static void Div()
        {
            throw new NotImplementedException();
        }

        private static void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }

        #endregion

    }
}
