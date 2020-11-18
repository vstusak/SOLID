using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP
{
    internal class BonusesRulesProvider : IBonusesRulesProvider
    {
        public IEnumerable<int> ApplyRules(IEnumerable<Salary> salaries)
        {
            var bonuses = new List<int>();

            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }

            return bonuses;
        }
    }

}

