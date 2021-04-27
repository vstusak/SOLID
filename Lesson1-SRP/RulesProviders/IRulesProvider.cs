using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public interface IRulesProvider
    {
        double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication);
        List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries);
    }
}