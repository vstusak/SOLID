using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public interface IMultiplicationRulesProvider
    {
        double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication);
    }
}
