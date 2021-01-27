using System;
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

            AdvancedCalc_ConsoleReader();

            //SimpleCalc_ConsoleReader();

            //AdvancedCalc_StringReader();
        }


        static void AdvancedCalc_ConsoleReader()
        {
            try
            {
                ConsoleDataReader consoleDataReader = new ConsoleDataReader();
                ConsoleDataWriter consoleDataWriter = new ConsoleDataWriter();

                CalculatorAdvanced calcAdv = new CalculatorAdvanced(consoleDataReader, consoleDataWriter, logger);

                while (true)
                {
                    calcAdv.Calculate();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\nError: {e.Message.Replace("\r", "\\r").Replace("\t", "\\t")}\n");
            }

        }


        static void SimpleCalc_ConsoleReader()
        {
            try
            {
                ConsoleDataReader consoleDataReader = new ConsoleDataReader();
                ConsoleDataWriter consoleDataWriter = new ConsoleDataWriter();

                CalculatorSimple calcSimple = new CalculatorSimple(consoleDataReader, consoleDataWriter, logger);

                while (true)
                {
                    calcSimple.Calculate();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\nError: {e.Message.Replace("\r", "\\r").Replace("\t", "\\t")}\n");
            }

        }


        static void AdvancedCalc_StringReader()
        {
            try
            {
                StringDataWriter stringDataWriter = new StringDataWriter();
                
                CalculatorAdvanced calcAdv = new CalculatorAdvanced(null, stringDataWriter, logger);

                while (true)
                {
                    Console.Write("Enter a command in format 'cmd p1 p2 ...':");

                    var stringDataReader = new StringDataReader(Console.ReadLine());
                    calcAdv.SetDataReader(stringDataReader);

                    calcAdv.Calculate();

                    Console.WriteLine(stringDataWriter.ToStringDecorated());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n\nError: {e.Message.Replace("\r", "\\r").Replace("\t", "\\t")}\n");
            }

        }

    }
}
