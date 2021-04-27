using System.Collections.Generic;

namespace Lesson1_SRP.Entities
{
    public interface IPerson
    {
        int BaseSalary { get; }
        IEnumerable<Salary> Salaries { get; }

        void AddSalary(Salary salary);
        void AddSalaries(IEnumerable<Salary> salaries);
    }
}