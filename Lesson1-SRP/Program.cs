using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson1_SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var multiplicationProvider = new MultiplicationProvider();
            var bonusesProvider = new BonusesProvider();
            var retirementCalculator = new RetirementCalculator(multiplicationProvider, bonusesProvider);
            SalariesProvider salariesProvider = new SalariesProviderDb();

            //retirementCalculator.GenerateSalaries();
            var salaries = salariesProvider.GetData();
            var retirementSalary = retirementCalculator.CalculateRetirementMonthlySalary(salaries, new Employee());

            Console.WriteLine(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");

        }
    }

    public class RetirementCalculator
    {
        private readonly IMultiplicationProvider _multiplicationProvider;
        private readonly IBonusesProvider _bonusesProvider;

        public RetirementCalculator(IMultiplicationProvider multiplicationProvider, IBonusesProvider bonusesProvider)
        {
            _multiplicationProvider = multiplicationProvider;
            _bonusesProvider = bonusesProvider;
        }

        //public int CalculateRetirementMonthlySalary(IEnumerable<Salary> salaries)
        //{
        //    return CalculateRetirementMonthlySalary(salaries, new Employee());
        //}

        public int CalculateRetirementMonthlySalary(IEnumerable<Salary> salaries, IEmployee employee)
        {
            //move rules to rules provider (icnluding base salary)
            //drive rules provider based on roles (based/manager/ceo)
            //move rules to roles

            var multiplicationResult = _multiplicationProvider.ApplyRules(employee.MultiplicationDefault, salaries);
            var bonusesResult = _bonusesProvider.ApplyRules(salaries);

            //example how to use more returning types
            //var result = GetSomething(salaries);
            //Console.WriteLine(result.multiplication);

            return Convert.ToInt32(employee.BaseRetirementSalary * multiplicationResult + bonusesResult.Sum());
        }

        //public (int multiplication, int bonuses) GetSomething(IEnumerable<Salary> salaries)
        //{
        //    return (0, 1000);
        //}
    }

    public class BonusesProvider : IBonusesProvider
    {
        public IEnumerable<int> ApplyRules(IEnumerable<Salary> salaries)
        {
            var bonuses = new List<int>();

            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {

                bonuses.Add(2000);
            }

            return bonuses;
        }
    }

    public class MultiplicationProvider : IMultiplicationProvider
    {

        //todo: data vs reference types
        public double ApplyRules(double multiplication, IEnumerable<Salary> salaries)
        {
            var enumerable = salaries.ToList();
            if (enumerable.Count() > 50)
            {
                multiplication += 0.3;
            }

            if (enumerable.Select(salary => salary.Value).Average() > 30000)
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
        public async virtual Task<IEnumerable<Salary>> GetData()
        {
            //system.io.abstractions
            //return JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json")).ToList();

            var text = await File.ReadAllTextAsync("salaries.json");
            var result = JsonSerializer.Deserialize<IEnumerable<Salary>>(text);

            return result;
        }
    }

    public class SalariesProviderDb : SalariesProvider
    {
        public override IEnumerable<Salary> GetData()
        {
            return GenerateSalaries();
        }

        private List<Salary> GenerateSalaries()
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
}
