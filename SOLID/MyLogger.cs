using System;
using System.IO;

namespace SOLID
{
    internal class MyLogger
    {
        public MyLogger()
        {
        }

        internal void LogHistory(string output)
        {
            File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
        }
    }
}