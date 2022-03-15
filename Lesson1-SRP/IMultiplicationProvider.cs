using System.Collections.Generic;

namespace Lesson1_SRP
{
    public interface IMultiplicationProvider
    {
        double ApplyRules(double multiplication, IEnumerable<Salary> salaries);
        public int Year { get; set; }
    }
}