using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace Lesson1_SRP
{
    public class RetirementCalculator
    {
        private readonly IRetirementRulesProvider _rulesProvider;
        public RetirementCalculator(IRetirementRulesProvider rulesProvider)
        {
            _rulesProvider = rulesProvider;
        }

        public int Process(List<Salary> salaries, int baseRetirementSalary)
        {
            if (baseRetirementSalary <= 0)
            {
                try
                {
                    RaiseException();
                }
                catch (NegativeSalaryException nse)
                {
                    Console.WriteLine(nse);
                    //throw;
                    //throw new NegativeSalaryException();
                    throw nse;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                    //throw new Exception();
                    //throw e;
                }
            }

            var multiplication = _rulesProvider.GetMultiplication(salaries);
            var bonusSum = _rulesProvider.GetBonuses(salaries);
           
            return Convert.ToInt32(baseRetirementSalary * multiplication + bonusSum);
        }

        private void RaiseException()
        {
            throw new NegativeSalaryException();
        }
    }
}