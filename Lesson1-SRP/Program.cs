using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var multiplicationRulesProvider = new MultiplicationRulesProvider();
            var bonusesRulesProvider = new BonusesRulesProvider();
            var retirementCalculator = new RetirementCalculator(multiplicationRulesProvider, bonusesRulesProvider);
            var logger = new Logger();

            //logic to set correct role salaries
            SalariesProvider provider = new SalariesGeneratorCEO();
            //SalariesGenerator salariesGenerator = new SalariesGenerator();
            var salaries = provider.Load();

            var retirementSalary = retirementCalculator.Process(salaries, 10000);

            logger.Log($"Your retirement salary will be {retirementSalary}");
            logger.Log(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }

    internal class BonusesRulesProvider : IBonusesRulesProvider
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

    internal class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class RetirementCalculator
    {
        private readonly IMultiplicationRulesProvider _multiplicationRulesProvider;
        private readonly IBonusesRulesProvider _bonusesRulesProvider;

        public RetirementCalculator(IMultiplicationRulesProvider multiplicationRulesProvider, IBonusesRulesProvider bonusesRulesProvider)
        {
            _multiplicationRulesProvider = multiplicationRulesProvider;
            _bonusesRulesProvider = bonusesRulesProvider;
        }

        public int Process(IEnumerable<Salary> salaries, Employe emplyoee)
        {
            //double multiplication;
            //switch (employeType)
            //{
            //    case EmployeType.Employee:
            //        multiplication = 1;
            //        break;
            //    case EmployeType.CEO:
            //        multiplication = 1.5;
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException(nameof(employeType), employeType, null);
            //}

            //var bonuses = new List<int>();

            //1. neni dodrzeno SRP - presun pryc do vlastnich objektu
            //if (salaries.Count() > 50)
            //{
            //    multiplication += 0.3;
            //}

            //if (salaries.Select(salary => salary.Value).Average() > 30000)
            //{
            //    multiplication += 1;
            //}

            //if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            //{
            //    bonuses.Add(2000);
            //}

            
            var resultMultiplication = _multiplicationRulesProvider.ApplyRules(salaries, multiplication);
            var resultBonuses = _bonusesRulesProvider.ApplyRules(salaries);

            return Convert.ToInt32(baseSalary * resultMultiplication + resultBonuses.Sum());
        }
    }

    //public enum EmployeType
    //{
    //    Employee,
    //    CEO,
    //    Manager
    //}

    public interface IBonusesRulesProvider
    {
        IEnumerable<int> ApplyRules(IEnumerable<Salary> salaries);
    }

    public interface IMultiplicationRulesProvider
    {
        double ApplyRules(IEnumerable<Salary> salaries, double multiplication);
    }

    public class MultiplicationRulesProvider : IMultiplicationRulesProvider
    {
        public double ApplyRules(IEnumerable<Salary> salaries, double multiplication)
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
}
