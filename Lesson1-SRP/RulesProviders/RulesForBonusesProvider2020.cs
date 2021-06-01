using Lesson1_SRP.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP.RulesProviders
{
    public class RulesForBonusesProvider2020 : IRulesForBonusesProvider
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
    }
}