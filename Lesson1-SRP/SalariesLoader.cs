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
        public List<Salary> GetSalaries()
        {
            return JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json")).ToList();
        }
    }
}
