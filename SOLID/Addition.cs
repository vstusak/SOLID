using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Addition
    {
        public int Add()
        {
            Console.WriteLine("\nset value 1");
            var value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("set value 2");
            var value2 = int.Parse(Console.ReadLine());

            var result = value1 + value2;

            var output = $"{value1} + {value2} = {result}";
            Console.WriteLine(output);
            LoggerHistory.LogHistory(output);

            return Convert.ToInt32(output);
        }
    }
}
