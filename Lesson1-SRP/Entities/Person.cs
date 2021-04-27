using System.Collections.Generic;

namespace Lesson1_SRP.Entities
{
    public abstract class Person : IPerson
    {
        private List<Salary> _salaries = new List<Salary>();

        public abstract int BaseSalary { get; }

        public IEnumerable<Salary> Salaries { get; }

        public void AddSalaries(IEnumerable<Salary> salaries)
        {
            _salaries.AddRange(salaries);
        }

        public void AddSalary(Salary salary)
        {
            _salaries.Add(salary);
        }
    }
}