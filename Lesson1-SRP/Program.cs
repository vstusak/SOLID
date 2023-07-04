using System;

namespace Lesson1_SRP
{
    public class Program
    {
        private const string CongratulationsAndHaveANiceRetirement = "Congratulations and have a nice retirement";
        private const string YouWillNeedAdditionalWorkNowOrInRetirementSorry = "You will need additional work now or in retirement, sorry";

        static void Main(string[] args)
        {
            var salaryProvider = new SalaryProvider();
            var salaries = salaryProvider.GetSalaries("salaries.json");
            var provider = new RetirementRulesProvider2021();
            var retirementCalculator = new RetirementCalculator(provider);

            //retirementCalculator.GenerateSalaries();
            var retirementSalary = retirementCalculator.Process(salaries, 10000);

            Console.WriteLine(retirementSalary > 20000
                ? CongratulationsAndHaveANiceRetirement
                : YouWillNeedAdditionalWorkNowOrInRetirementSorry);
        }
    }

}
