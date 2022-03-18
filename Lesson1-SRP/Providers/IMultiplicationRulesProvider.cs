using System.Collections.Generic;

namespace Lesson1_SRP
{
    public interface IMultiplicationRulesProvider
    {
        string TenantId { get; set; }
        Address TenantAddress { get; set; }
        double ApplyRules(IEnumerable<Salary> salaries, double multiplication);
    }

    public class Address
    {
        public virtual Street Street { get; set; }
        public string City { get; set; }
    }

    public class Street
    {
        public virtual string Name { get; set; }
        public int Number { get; set; }
    }
}

