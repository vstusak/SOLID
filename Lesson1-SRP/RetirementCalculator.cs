﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lesson1_SRP
{
    public class RetirementCalculator
    {

        
        public int CalculateRetirementSalary(List<Salary> salaries)
        {
            var baseSalary = 10000;
            var multiplication = GetMultiplication(salaries);
            var bonuses = GetBonuses(salaries);

            return Convert.ToInt32(baseSalary * multiplication + bonuses.Sum());
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

        public List<int> GetBonuses(List<Salary> salaries)
        {
            var bonuses = new List<int>();

            if (salaries.Select(salary => salary.Value).Any(value => value > 47000))
            {
                bonuses.Add(2000);
            }

            return bonuses;
        }
    }
}