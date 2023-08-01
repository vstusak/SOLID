using System;
using System.Collections.Generic;

namespace Lesson1_SRP
{
    public class RetirementCalculator
    {
        private readonly IRetirementRulesProvider _rulesProvider;
        public RetirementCalculator(IRetirementRulesProvider rulesProvider)
        {
            _rulesProvider = rulesProvider;
        }

        public int Process(List<Salary> salaries, int baseRetirementSalary)
        {
            var multiplication = _rulesProvider.GetMultiplication(salaries);
            var bonusSum = _rulesProvider.GetBonuses(salaries);

            return Convert.ToInt32(baseRetirementSalary * multiplication + bonusSum);
        }
    }
}
