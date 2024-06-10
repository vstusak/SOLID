using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_SRP
{
    public interface IBonusProvider
    {
        List<int> GetBonuses(List<Salary> salaries);
    }

    
}
