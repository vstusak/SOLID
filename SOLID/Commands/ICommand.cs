using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Commands
{
    interface ICommand
    {
        char CommandName { get; }
        int NumberOfParameters { get; }

        double Calculate(IEnumerable<double> Parameters, out string DecoratedOutput);
    }
}
