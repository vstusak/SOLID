using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.Logger
{
    class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string Message)
        {
            File.AppendAllText(_filePath, $"[{DateTime.UtcNow}] {Message.Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t")}\n");
        }
    }
}
