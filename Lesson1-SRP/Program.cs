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
            var logger = new Logger();

            var salaries = new SalariesGenerator().Load();
            retirementCalculator.Process(salaries);

            logger.Log(retirementCalculator.RetirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }

    public class SalariesProvider
    {
        public virtual IEnumerable<Salary> Load()
        {
            //using system.io.abstraction
            return JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json"));
        }
    }

    public class SalariesGenerator : SalariesProvider
    {
        public override IEnumerable<Salary> Load()
        {
            var salaryGenerator = new Random();

            var salaries = new List<Salary>();
            for (int i = 0; i < 100; i++)
            {
                salaries.Add(new Salary
                    { DateTime = new DateTime(2020, 9, 13).AddMonths(i * -1), Value = salaryGenerator.Next(5000, 50000) });
            }

            return salaries;
            //var json = JsonSerializer.Serialize(salaries);
            //File.AppendAllText("salaries.json", json);
        }
    }

    internal class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class RetirementCalculator
    {
        public int RetirementSalary { get; set; }

        public void Process(IEnumerable<Salary> salaries)
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
