using System.Collections.Generic;

namespace Lesson1_SRP
{
    public interface IMultiplicationRulesProvider
    {
        double ApplyRules(IEnumerable<Salary> salaries, double multiplication);
    }

}

