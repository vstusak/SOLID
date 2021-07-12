using SOLID.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Tests
{
    public class LoggerMock : ILogger
    {
        public string LastMessage { get; set; }

        public void Log(string message)
        {
            LastMessage = message;
        }
    }
}
