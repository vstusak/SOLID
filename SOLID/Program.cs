using System;
using System.IO;

namespace SOLID
{
    class Program : Calculator
    {
        static void Main(string[] args)
        {
            var reader = new lineReader();
            var operation = reader.ReadCommand();
            var value1 = reader.ReadValue();
            var value2 = reader.ReadValue();
        
            Calculator.Calculated(value1, value2, operation);

            //call new object Calculator -> method Calculated
            //method calculate should return Result
            //5-7 rows
            //only Main in class Program
            
        }
    }
}
