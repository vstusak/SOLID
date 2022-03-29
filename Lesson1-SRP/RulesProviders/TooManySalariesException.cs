using System;
using System.Runtime.Serialization;

namespace Lesson1_SRP.RulesProviders
{
    public class TooManySalariesException : Exception
    {
        public TooManySalariesException()
        {
        }

        public TooManySalariesException(string message) : base(message)
        {
        }

        public TooManySalariesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}