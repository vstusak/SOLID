using System.Collections.Generic;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP.Calculations
{
    public class BonusProvider1950AndYounger : IBonusProvider
    {
        public List<int> GetBonuses(List<Salary> salaries)
        {
            var bonuses = new List<int>();
            bonuses.Add(5);
            return bonuses;
        }
    }
}