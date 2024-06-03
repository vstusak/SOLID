using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_SRP
{
    public class WordingProvider
    {
        public string GetRetirementMessage(int monthlyRetirementSalary)
        {
            if (monthlyRetirementSalary > 20000)
            {
                return "Congratulations and have a nice retirement";
            }
            else
            {
                return "You will need additional work now or in retirement, sorry";
            }
        }
    }
}
