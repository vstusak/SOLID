using Lesson1_SRP.Entities;
using Lesson1_SRP.RulesProviders;
using System;
using System.Linq;

namespace Lesson1_SRP
{
    public class RetirementCalculator : IRetirementCalculator
    {
        //public int RetirementSalary { get; set; }
        private readonly IRulesForBonusesProvider _rulesForBonusesProvider;
        private readonly IMultiplicationRulesProvider _multiplicationRulesProvider;

        public RetirementCalculator(IRulesForBonusesProvider rulesForBonusesProvider, IMultiplicationRulesProvider multiplicationRulesProvider)
        {
            _rulesForBonusesProvider = rulesForBonusesProvider;
            _multiplicationRulesProvider = multiplicationRulesProvider;
        }

        // TODO Apply CEO base salary - FROM outside object
        public int Calculate(IPerson person)
        {
            //var baseSalary = 10000;
            double multiplication = 1;

            //salaries.re //ctrl + k, ctrl + c

            multiplication = _multiplicationRulesProvider.ApplyRulesForMultiplication(person.Salaries, multiplication);

            var bonuses = _rulesForBonusesProvider.ApplyRulesForBonuses(person.Salaries);

            Console.WriteLine(_multiplicationRulesProvider.Year);
            _multiplicationRulesProvider.Year = 1988;
            Console.WriteLine(_multiplicationRulesProvider.Year);


            var result = Convert.ToInt32(person.BaseSalary * multiplication + bonuses.Sum());
            return result;
        }
    }
}