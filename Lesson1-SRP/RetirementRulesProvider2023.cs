using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP
{
    public class RetirementRulesProvider2023 : IRetirementRulesProvider
    {
        public double GetMultiplication(List<Salary> salaries)
        {
            double multiplication = 1;
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

        public int GetBonuses(List<Salary> salaries)
        {
            var bonuses = new List<int>();
            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }
            return bonuses.Sum();
        }
    }

}
