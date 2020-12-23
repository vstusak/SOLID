using System;
using System.IO;

namespace SOLID.Logger
{
    public class JsonLogger : ILogger
    {
        public void LogHistory(string message)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {message}\n");
        }
    }
}
