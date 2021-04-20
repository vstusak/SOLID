using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lesson1_SRP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rulesProvider = new RulesProvider2021();
            var retirementCalculator = new RetirementCalculator(rulesProvider);

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

    public class RulesProvider2020 : IRulesProvider
    {
        public List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries)
        {
            var bonuses = new List<int>();
            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }
            return bonuses;
        }

        public double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
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

    public class RulesProvider2021 : IRulesProvider
    {
        public List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries)
        {
            var emptyList = new List<int>();
            return emptyList;
        }

        public double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication)
        {
            return multiplication;
        }
    }

    public interface IRulesProvider
    {
        double ApplyRulesForMultiplication(IEnumerable<Salary> salaries, double multiplication);
        List<int> ApplyRulesForBonuses(IEnumerable<Salary> salaries);
    }

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

    public class Salary
    {
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
    }

    public class SalariesProvider
    {
        public List<Salary> GetSalaries()
        {
            var result = GenerateSalaries(Roles.Undefined);
            //return JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json")).ToList();
            return result.ToList();
        }

        public IEnumerable<Salary> GenerateSalaries(Roles role)
        {
            var salaryGenerator = new Random();

            var salaries = new List<Salary>();

            var min = 5000;
            var max = 50000;
            if (role == Roles.CEO)
            {
                min = 40000;
            }
            for (int i = 0; i < 100; i++)
            {
                salaries.Add(new Salary
                { DateTime = new DateTime(2020, 9, 13).AddMonths(i * -1), Value = salaryGenerator.Next(min, max) });
            }

            //var json = JsonSerializer.Serialize(salaries);
            //File.AppendAllText("salaries.json", json);

            return salaries;
        }
    }

    public enum Roles
    {
        Undefined,
        Worker,
        Manager,
        CEO
    }

    public interface IPerson
    {
        int BaseSalary { get; }
        IEnumerable<Salary> Salaries { get; }

        void AddSalary(Salary salary);
        void AddSalaries(IEnumerable<Salary> salaries);
    }

    public abstract class Person : IPerson
    {
        private List<Salary> _salaries = new List<Salary>();

        public abstract int BaseSalary { get; }

        public IEnumerable<Salary> Salaries { get; }

        public void AddSalaries(IEnumerable<Salary> salaries)
        {
            _salaries.AddRange(salaries);
        }

        public void AddSalary(Salary salary)
        {
            _salaries.Add(salary);
        }
    }

    public class Worker : Person, IPerson
    {
        public override int BaseSalary => 20000;
    }

    public class CEO : Person, IPerson
    {
        public override int BaseSalary => 40000;
    }
}