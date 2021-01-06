using System;
using System.IO;

namespace SOLID
{
    public class Logger : ILogger
    {
        private readonly string _logFileName = "log.json";
        
        public Logger()
        {
        }

        public Logger(string logFileName)
        {
            _logFileName = logFileName;
        }

        public void Log(string output)
        {
            File.AppendAllText(_logFileName, $"{DateTime.UtcNow} : {output}\n");
        }
    }
}
