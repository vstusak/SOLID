using System;

namespace Lesson1_SRP
{
    //Single responsibility principle - jeden duvod ke zmene, tridy/metody delaji jen jednu vec
    public class Program
    {
        static void Main(string[] args)
        {
            var retirementCalculator = new RetirementCalculator();

            //retirementCalculator.GenerateSalaries();
            var retirementSalary = retirementCalculator.Process(10000);

            Console.WriteLine(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }
    //TODO - premistit tridu do jineho souboru

    public class Salary
    {
        public DateTime DateTime { get; set; }
        public int Value { get; set; }
    }
}
