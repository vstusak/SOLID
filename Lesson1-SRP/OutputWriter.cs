using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_SRP
{
    internal class OutputWriter
    {
        //TODO přejmenovat na ConsoleOutputWriter
        //TODO přidat interface, dodělat FileOutputWriter
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
