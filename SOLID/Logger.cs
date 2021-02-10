using System;
using System.IO;

namespace SOLID
{
    public class Logger
    {
        public static void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }
    }
}