using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IReader
    {
        string ReadCommand();
    }

    public class lineReader : IReader
    {
        public string ReadCommand()
        {
            return Console.ReadLine();
        }
    }
}
