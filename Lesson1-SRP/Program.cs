using System;

namespace Lesson1_SRP
{
    //Single responsibility principle - jeden duvod ke zmene, tridy/metody delaji jen jednu vec
    public class Program
    {
        static void Main(string[] args)
        {
            var retirementCalculator = new RetirementCalculator();
            var wordingProvider = new WordingProvider();
            var outputWriter = new OutputWriter();

            //retirementCalculator.GenerateSalaries();
            var retirementSalary = retirementCalculator.Process(10000);

            var retirementMessage = wordingProvider.GetRetirementMessage(retirementSalary);
            outputWriter.WriteMessage(retirementMessage);
        }
    }
}
