using System;
using System.IO;

namespace SOLID
{
    class Program : Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write operation (+. -, *, /)");
            var reader = new lineReader();
            var calculator = new Calculator();
            var operation = reader.ReadCommand();

            Console.WriteLine(operation);
            //calculator.Calculated(operation);
            //call new object Calculator -> method Calculated
            //method calculate should return Result
            //5-7 rows
            //only Main in class Program
            
        }
    }
}
