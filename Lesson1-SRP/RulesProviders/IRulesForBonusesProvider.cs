using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public interface IRulesForBonusesProvider
    {
        List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries);
    }
}