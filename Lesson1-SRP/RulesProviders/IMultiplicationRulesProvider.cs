using Lesson1_SRP.Entities;
using System.Collections.Generic;

namespace Lesson1_SRP.RulesProviders
{
    public interface IMultiplicationRulesProvider
    {
        public int Year { get; set; }
        public Address Address { get; set; }

        double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication);
    }

    public class Street
    {
        public virtual string Name { get; set; }
        public int Number { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public virtual Street Street { get; set; }

    }
}
