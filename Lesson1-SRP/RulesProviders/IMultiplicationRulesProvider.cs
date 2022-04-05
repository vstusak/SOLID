using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public interface IMultiplicationRulesProvider
    {
        public int Year { get; set; }
        double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication);
    }
}
