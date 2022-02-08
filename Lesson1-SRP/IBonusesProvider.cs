using System.Collections.Generic;

namespace Lesson1_SRP
{
    public interface IBonusesProvider
    {
        IEnumerable<int> ApplyRules(IEnumerable<Salary> salaries);
    }
}