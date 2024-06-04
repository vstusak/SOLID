using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP
{
    public class Program
    {
        // imagine: tato metoda Main je "controller" pro api endpoint "GetMyRetirement"
        // Needs to follow our (imaginary) Business rule:
        //  As a logged-in user I need to be able to call api endpoint to get calculation whether I will need to work during retirement.
        static void Main(string[] args)
        {
            var retirementCalculator = new RetirementCalculator();
            var wordingProvider = new WordingProvider();
            var outputWriter = new OutputWriter();

            var salaries = JsonSerializer.Deserialize<IEnumerable<Salary>>(File.ReadAllText("salaries.json")).ToList(); //TODO extract to own class.
            //retirementCalculator.GenerateSalaries();
            var retirementSalaryResult = retirementCalculator.CalculateRetirementSalary(salaries);

            var outputMessage = wordingProvider.GetOutputMessageForRetirementSalaryCalculation(retirementSalaryResult);

            outputWriter.WriteToConsole(outputMessage);
        }
    }
}
