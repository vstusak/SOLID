using System;
using System.Collections.Generic;

namespace Lesson1_SRP
{
    public interface IMultiplicationProvider
    {
        double ApplyRules(double multiplication, IEnumerable<Salary> salaries);
        public int Year { get; set; }

        public Address Address { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public virtual Street Street { get; set; }
    }

    public class Street
    {
        public virtual string Name { get; set; }
        public virtual int Number { get; set; }
    }
}