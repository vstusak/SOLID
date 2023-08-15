using System;

namespace Lesson1_SRP;

public class NegativeSalaryException: Exception
{
    public NegativeSalaryException()
    {
            
    }

    public NegativeSalaryException(string message):base(message)
    {
            
    }

    public NegativeSalaryException(string message, Exception inner):base(message, inner) 
    {
            
    }
}