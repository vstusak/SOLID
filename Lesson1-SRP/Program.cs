using System;

namespace Lesson1_SRP
{
    //Single responsibility principle - jeden duvod ke zmene, tridy/metody delaji jen jednu vec
    public class Program
    {
        static void Main(string[] args)
        {
            var year = 2030;
            
            IBonusProvider bonusProvider;
            if (year >= 2030)
            {
                /*true*/
                bonusProvider = new BonusProvider2030();
            }
            /*false*/
            else
            {
                bonusProvider = new BonusProvider();
            }
            var salariesLoader = new SalaryLoader();
            var multiplicationProvider = new MultiplicationProvider();
            var retirementCalculator = new RetirementCalculator(bonusProvider, multiplicationProvider);
            var wordingProvider = new WordingProvider();
            var outputWriter = new OutputWriter();
         
            var salaries = salariesLoader.GetSalaries();
            var retirementSalary = retirementCalculator.Process(salaries);

            var retirementMessage = wordingProvider.GetRetirementMessage(retirementSalary);
            outputWriter.WriteMessage(retirementMessage);
        }
    }
}
