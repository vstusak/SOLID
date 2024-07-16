using Lesson1_SRP.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Lesson1_SRP
{
    public class SalariesLoader
    {
        private const string SalariesFileName = "salaries.json";

        public List<Salary> GetSalaries()  // TODO introduce "salaries" parameter from console from args
        {
            var readAllText = File.ReadAllText(SalariesFileName);
            var salaries = JsonSerializer.Deserialize<IEnumerable<Salary>>(readAllText).ToList();
            return salaries;
        }
    }
}
