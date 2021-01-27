using System;
using System.IO;

namespace SOLID
{
    partial class Program
    {
        public class FileLogger : ILogger
        {
            public string Path { get; set; }

            public FileLogger(string path)
            {
                Path = path;
            }
            public void Log(string message)
            {
                File.AppendAllText(Path, $"{DateTime.UtcNow} : {message}\n");
            }
        }
    }
}