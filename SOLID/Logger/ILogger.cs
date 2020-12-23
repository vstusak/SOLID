using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Logger
{
    public interface ILogger
    {
        void LogHistory(string message);
    }
}
