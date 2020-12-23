using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public class Output
    {
        public int FirstValue { get; set; }

        public int SecondValue { get; set; }
        public Operand Operand { get; set; }

        public double Result { get; set; }
    }
}
