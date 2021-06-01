using Lesson1_SRP.Entities;
using Lesson1_SRP.Enums;
using Lesson1_SRP.RulesProviders;
using System;

namespace Lesson1_SRP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var rulesProvider = new RulesForBonusesProvider2021();
            var multiplicationRulesProvider = new MultiplicationRulesProvider2021();
            var retirementCalculator = new RetirementCalculator(rulesProvider, multiplicationRulesProvider);

            //retirementCalculator.GenerateSalaries();

            var salaryProvider = new SalariesProvider();

            var salaries = salaryProvider.GenerateSalaries(Roles.CEO);

            var person = new CEO();
            person.AddSalaries(salaries);

            var retirementSalary = retirementCalculator.Calculate(person);

            Console.WriteLine(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }
}