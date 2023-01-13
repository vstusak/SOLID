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
            var salaryProvider = new SalaryProvider();
            var salaries = salaryProvider.GetSalaries("salaries.json");
            var retirementCalculator = new RetirementCalculator();

            //retirementCalculator.GenerateSalaries();
            retirementCalculator.Process(salaries);

            Console.WriteLine(retirementCalculator.RetirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }

    public class RetirementCalculator
    {
        public int RetirementSalary { get; set; }

        public void Process(List<Salary> salaries)
        {
            var baseSalary = 10000;
            double multiplication = 1;
            var bonuses = new List<int>();


            if (salaries.Count() > 50)
            {
                multiplication += 0.3;

            }

            if (salaries.Select(salary => salary.Value).Average() > 30000)
            {
                multiplication += 1;
            }

            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }

            RetirementSalary = Convert.ToInt32(baseSalary * multiplication + bonuses.Sum());
        }
    }

    public class Salary
    {
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
    }
}
