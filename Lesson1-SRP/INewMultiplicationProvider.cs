using System.Collections.Generic;

namespace Lesson1_SRP;

public interface INewMultiplicationProvider
{
    int GetMultiplication(List<Salary> salaries);
}