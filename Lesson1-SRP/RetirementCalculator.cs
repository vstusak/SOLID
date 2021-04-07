using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson1_SRP
{
    public class RetirementCalculator
    {
        //private readonly object lockObject = new object();
        //private readonly static object lockObject2 = new object();

        //private readonly Dictionary<int, string> myMemory = new Dictionary<int, string>();

        private readonly IMultiplicationRulesProvider _multiplicationRulesProvider;
        private readonly IBonusesRulesProvider _bonusesRulesProvider;

        public RetirementCalculator(IMultiplicationRulesProvider multiplicationRulesProvider, IBonusesRulesProvider bonusesRulesProvider)
        {
            _multiplicationRulesProvider = multiplicationRulesProvider;
            _bonusesRulesProvider = bonusesRulesProvider;
        }

        public int Process(IEnumerable<Salary> salaries, IEmployee employee)
        {
            //lock (lockObject)
            //{
            //    myMemory.Add(0, "hello");
            //}

            //lock (lockObject2)
            //{
            //    File.AppendAllText("C:\temp.txt", "world");
            //}

            //read (hello)
            //origin + new 
            //write

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

            
            var resultMultiplication = _multiplicationRulesProvider.ApplyRules(salaries, employee.Multiplication);
            var resultBonuses = _bonusesRulesProvider.ApplyRules(salaries);

            return Convert.ToInt32(employee.BaseRetirementSalary * resultMultiplication + resultBonuses.Sum());
        }
    }

}

