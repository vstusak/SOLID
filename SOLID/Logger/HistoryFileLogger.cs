using System;
using System.IO;

namespace SOLID
{
    partial class Program
    {
        public class HistoryFileLogger : ICalculatorLogger
        {
            public void LogHistory(string output)
            {
                File.AppendAllText("log.json", $"{DateTime.UtcNow} : {output}\n");
            }
        }
    }
}
