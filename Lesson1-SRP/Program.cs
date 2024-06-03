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

            //TODO nahradit konzoli nahráváním do souboru
            //2 zodpovědnosti: vypsání, if
            var message = wordingProvider.GetMessage(retirementSalary);
            outputWriter.WriteMessage(message);
        }
    }
    //TODO - premistit tridu do jineho souboru

    public class Salary
    {
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
    }
}
