using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public class RulesProvider2021 : IRulesProvider
    {
        public List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries)
        {
            var emptyList = new List<int>();
            return emptyList;
        }

        public double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
        {
            return multiplication;
        }
    }
}