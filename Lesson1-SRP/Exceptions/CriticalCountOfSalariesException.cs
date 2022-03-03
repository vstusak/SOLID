using System;

namespace Lesson1_SRP.Exceptions;

public class CriticalCountOfSalariesException : Exception
{
    public CriticalCountOfSalariesException()
    {
        
    }

    public CriticalCountOfSalariesException(string message) : base(message)
    {
        
    }

    public CriticalCountOfSalariesException(string message, Exception innerException) : base(message, innerException)
    {
        
    }
}