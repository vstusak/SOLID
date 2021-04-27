using Lesson1_SRP.Entities;
using Lesson1_SRP.RulesProviders;
using System;
using System.Linq;

namespace Lesson1_SRP
{
    public class RetirementCalculator
    {
        //public int RetirementSalary { get; set; }
        private IRulesProvider _rulesProvider;
        public RetirementCalculator(IRulesProvider rulesProvider)
        {
            _rulesProvider = rulesProvider;
        }

        // TODO Apply CEO base salary - FROM outside object
        public int Calculate(IPerson person)
        {
            //var baseSalary = 10000;
            double multiplication = 1;

            //salaries.re //ctrl + k, ctrl + c

            multiplication = _rulesProvider.ApplyRulesForMultiplication(person.Salaries, multiplication);

            var bonuses = _rulesProvider.ApplyRulesForBonuses(person.Salaries);

            var result = Convert.ToInt32(person.BaseSalary * multiplication + bonuses.Sum());
            return result;
        }
    }
}