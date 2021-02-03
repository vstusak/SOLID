using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Utilities
{
    public interface ILogger
    {
#warning Add override with LogLevel?
#warning Add async?
        void Log(string message);
    }
}
