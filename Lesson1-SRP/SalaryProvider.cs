using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lesson1_SRP
{
    public class SalaryProvider
    {

        public List<Salary> GetSalaries(string path)
        {
            return JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText(path)).ToList();
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