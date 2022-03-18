using System.Collections.Generic;
using System.Linq;
using Lesson1_SRP.Exceptions;

namespace Lesson1_SRP
{
    public class MultiplicationRulesProvider : IMultiplicationRulesProvider
    {
        public string TenantId { get; set; }
        public Address TenantAddress { get; set; }

        public double ApplyRules(IEnumerable<Salary> salaries, double multiplication)
        {
            if (salaries.IsNullOrEmpty())
            {
                return multiplication;
            }

            if (salaries.Count() > 100)
            {
                throw new CriticalCountOfSalariesException("Critical count of salaries reached.");
            }

            if (salaries.Count() > 50)
            {
                multiplication += 0.3;
            }

            if (salaries.Select(salary => salary.Value).Average() > 30000)
            {
                multiplication += 1;
            }

            return multiplication;
        }

        
    }

}

