using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Model
{
    class JobInput
    {
        string CommandName { get; set; }
        IEnumerable<double> Parameters { get; set; }
    }
}
