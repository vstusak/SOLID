using System.Collections.Generic;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP.Calculations
{
    public interface IMultiplicationProvider
    {
        double GetMultiplication(List<Salary> salaries);
    }
}