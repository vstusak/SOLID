using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.Logger
{
    public class Logger
    {
        public static void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }
    }
}
