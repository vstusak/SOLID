using System;

namespace Lesson1_SRP
{
    internal class TooManySalariesException : Exception
    {
        public TooManySalariesException()
        {
        }

        public TooManySalariesException(string message)
            : base(message)
        {
        }

        public TooManySalariesException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}