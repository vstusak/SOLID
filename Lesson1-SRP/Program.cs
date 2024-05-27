using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lesson1_SRP
{
    //Single responsibility principle - jeden duvod ke zmene, tridy/metody delaji jen jednu vec
    public class Program
    {
        static void Main(string[] args)
        {
            var retirementCalculator = new RetirementCalculator();

            //retirementCalculator.GenerateSalaries();
            var retirementSalary = retirementCalculator.Process();

            Console.WriteLine(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }
    //TODO - premistit tridu do jineho souboru
    public class RetirementCalculator
    {
        public int Process()
        {
            var baseSalary = 10000;
            double multiplication = 1;
            var bonuses = new List<int>();

            var salaries = JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json")).ToList();

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

            return Convert.ToInt32(baseSalary * multiplication + bonuses.Sum());
        }

        //TODO - getSalaryConditions? method - presunout ify
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

    public class Salary
    {
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
    }
}
