using System.Collections.Generic;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP.Calculations
{
    public interface IBonusProvider
    {
        List<int> GetBonuses(List<Salary> salaries);
    }
}