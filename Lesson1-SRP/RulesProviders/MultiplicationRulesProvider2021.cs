using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public class MultiplicationRulesProvider2021 : IMultiplicationRulesProvider
    {
        public int Year { get; set; }
        public Address Address { get; set; }

        public double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
        {
            return multiplication;
        }
    }
}
