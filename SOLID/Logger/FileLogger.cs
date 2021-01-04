using System;
using System.IO;

namespace SOLID.Logger
{ public class FileLogger : ILogger
    {
        public void Write(object output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }
    }
}