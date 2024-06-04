using System.Collections.Generic;
using System.Linq;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP.Calculations
{
    public class MultiplicationProvider
    {
        public double GetMultiplication(List<Salary> salaries)
        {
            double multiplication = 1;

            if (salaries.Count() > 50)
            {
                multiplication += 0.3;
            }

            if (salaries.Select(salary => salary.Value).Average() > 30000)
            {
                multiplication += 1;
            }

            return multiplication;
        }
    }
}