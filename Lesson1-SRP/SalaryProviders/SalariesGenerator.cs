using System;
using System.Collections.Generic;

namespace Lesson1_SRP
{
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
}