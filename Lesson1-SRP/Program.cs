using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lesson1_SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var retirementCalculator = new RetirementCalculator();

            //retirementCalculator.GenerateSalaries();


            var salaryProvider = new SalariesProvider();

            var salaries = salaryProvider.GetSalaries();

            var retirementSalary = retirementCalculator.Calculate(salaries);


            Console.WriteLine(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }

    public class RetirementCalculator
    {
        //public int RetirementSalary { get; set; }

        public int Calculate(IEnumerable<Salary> salaries)
        {
            var baseSalary = 10000;
            double multiplication = 1;
            var bonuses = new List<int>();

            //salaries.re //ctrl + k, ctrl + c

            multiplication = ApplyRulesForMultiplication(salaries, multiplication);

            ApplyRulesForBonuses(salaries, bonuses);

            return Convert.ToInt32(baseSalary * multiplication + bonuses.Sum());
        }

        private static void ApplyRulesForBonuses(IEnumerable<Salary> salaries, List<int> bonuses)
        {
            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }
        }

        private static double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
        {
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

    public class Salary
    {
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
    }

    public class SalariesProvider
    {
        public List<Salary> GetSalaries()
        {
            return JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json")).ToList();
        }

        public void GenerateSalaries()
        {
            var salaryGenerator = new Random();

            var salaries = new List<Salary>();
            for (int i = 0; i < 100; i++)
            {
                salaries.Add(new Salary
                { DateTime = new DateTime(2020, 9, 13).AddMonths(i * -1), Value = salaryGenerator.Next(5000, 50000) });
            }

            var json = JsonSerializer.Serialize(salaries);
            File.AppendAllText("salaries.json", json);
        }
    }
}
