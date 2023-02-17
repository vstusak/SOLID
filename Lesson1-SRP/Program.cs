using System;
using System.Collections.Generic;
using System.Linq;

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
            var retirementCalculator = new RetirementCalculator();

            //retirementCalculator.GenerateSalaries();
            var retirementSalary = retirementCalculator.Process(salaries, 10000);

            Console.WriteLine(retirementSalary > 20000
                ? CongratulationsAndHaveANiceRetirement
                : YouWillNeedAdditionalWorkNowOrInRetirementSorry);
        }
    }

    public class RetirementCalculator
    {
        private readonly RetirementRulesProvider _rulesProvider;
        public RetirementCalculator()
        {
            _rulesProvider = new RetirementRulesProvider();
        }

        public int Process(List<Salary> salaries, int baseRetirementSalary)
        {
            var multiplication = _rulesProvider.GetMultiplication(salaries);
            var bonusSum = _rulesProvider.GetBonuses(salaries);

            return Convert.ToInt32(baseRetirementSalary * multiplication + bonusSum);
        }
    }

    public interface IRetirementRulesProvider
    {
        double GetMultiplication(List<Salary> salaries);
        int GetBonuses(List<Salary> salaries);
    }

    public class Salary
    {
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
    }

    public class RetirementRulesProvider
    {
        public double GetMultiplication(List<Salary> salaries)
        {
            double multiplication = 1;
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

        public int GetBonuses(List<Salary> salaries)
        {
            var bonuses = new List<int>();
            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }
            return bonuses.Sum();
        }
    }

    public class RetirementRulesProvider2023
    {
        public double GetMultiplication(List<Salary> salaries)
        {
            double multiplication = 1;
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

        public int GetBonuses(List<Salary> salaries)
        {
            var bonuses = new List<int>();
            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }
            return bonuses.Sum();
        }
    }

}
