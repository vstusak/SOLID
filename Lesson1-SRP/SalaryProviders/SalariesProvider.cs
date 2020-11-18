using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Lesson1_SRP
{
    public class SalariesProvider
    {
        public virtual IEnumerable<Salary> Load()
        {
            //using system.io.abstraction
            return JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json"));
        }
    }
}