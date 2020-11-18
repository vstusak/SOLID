using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP
{
    public class MultiplicationRulesProvider : IMultiplicationRulesProvider
    {
        public double ApplyRules(IEnumerable<Salary> salaries, double multiplication)
        {
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

