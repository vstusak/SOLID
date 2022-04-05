using Lesson1_SRP.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP.RulesProviders
{
    public class MultiplicationRulesProvider2020 : IMultiplicationRulesProvider
    {
        public int Year { get; set; }

        public double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
        {
            if (salaries == null)
            {
                return multiplication;
            }
            if (salaries.Count() > 100)
            {
                throw new TooManySalariesException("Too many salaries found.");
            }
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
