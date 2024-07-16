using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP.Calculations
{
    public class RetirementCalculator
    {
        private readonly IMultiplicationProvider _multiplicationProvider;
        private readonly IBonusProvider _bonusProvider;

        public RetirementCalculator(IBonusProvider bonusProvider, IMultiplicationProvider multiplicationProvider)
        {
            _bonusProvider = bonusProvider;
            _multiplicationProvider = multiplicationProvider;
        }


        public int CalculateRetirementSalary(List<Salary> salaries)
        {
            var baseSalary = 10000;
            var multiplication = _multiplicationProvider.GetMultiplication(salaries);
            var bonuses = _bonusProvider.GetBonuses(salaries);

            return Convert.ToInt32(baseSalary * multiplication + bonuses.Sum());
        }

        /*
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
*/
    }

}