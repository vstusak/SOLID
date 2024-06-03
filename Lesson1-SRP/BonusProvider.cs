using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_SRP
{
    public class BonusProvider
    {
        public List<int> GetBonuses(List<Salary> salaries)
        {
            var bonuses = new List<int>();

            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }

            return bonuses;
        }
    }
}
