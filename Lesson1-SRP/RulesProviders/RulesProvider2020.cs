using Lesson1_SRP.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP.RulesProviders
{
    public class RulesProvider2020 : IRulesProvider
    {
        public List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries)
        {
            var bonuses = new List<int>();
            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }
            return bonuses;
        }

        public double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
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