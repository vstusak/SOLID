using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Reports
{
    public class Printer
    {
        public void Print(Report report)
        {
            Console.WriteLine(report);
        }
    }
}
