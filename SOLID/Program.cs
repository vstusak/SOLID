using System.IO;
using SOLID.IO;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new Writer();
            var reader = new lineReader(writer);
            var operation = reader.ReadCommand();
            var calculator = new Calculator(writer);
            var value1 = reader.ReadValue();
            var value2 = reader.ReadValue();
        
            calculator.Calculated(value1, value2, operation);

            //call new object Calculator -> method Calculated
            //method calculate should return Result
            //5-7 rows
            //only Main in class Program
            
        }

       
    }
}
