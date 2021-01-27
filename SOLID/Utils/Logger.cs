using System;
using System.IO;

namespace SOLID.Utils
{
    public class Logger : ILogger
    {
        private const string LogFileName = "log.json";

        public void LogHistory(string output)
        {
            File.AppendAllText(LogFileName, $"{DateTime.UtcNow} : {output}\n");
        }
    }
}
