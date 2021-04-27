using Lesson1_SRP.Entities;
using Lesson1_SRP.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1_SRP
{
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
}