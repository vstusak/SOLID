using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public class RulesForBonusesProvider2021 : IRulesForBonusesProvider
    {
        public List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries)
        {
            var emptyList = new List<int>();
            return emptyList;
        }
    }
}