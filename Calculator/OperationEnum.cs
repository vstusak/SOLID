using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum OperationEnum
    {
        Undefined,
        [Description("+")]
        Add,
        [Description("-")]
        Sub,
        [Description("*")]
        Mult,
        [Description("/")]
        Div
    }
}
