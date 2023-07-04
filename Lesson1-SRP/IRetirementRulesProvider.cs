using System.Collections.Generic;

namespace Lesson1_SRP
{
    public interface IRetirementRulesProvider
    {
        double GetMultiplication(List<Salary> salaries);
        int GetBonuses(List<Salary> salaries);
    }

}
