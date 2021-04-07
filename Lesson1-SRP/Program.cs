namespace Lesson1_SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var multiplicationRulesProvider = new MultiplicationRulesProvider();
            var bonusesRulesProvider = new BonusesRulesProvider();
            var retirementCalculator = new RetirementCalculator(multiplicationRulesProvider, bonusesRulesProvider);
            //var retirementCalculator2 = new RetirementCalculator(multiplicationRulesProvider, bonusesRulesProvider);
            var employee = new Employee();
            var logger = new Logger();

            //logic to set correct role salaries
            SalariesProvider provider = new SalariesGeneratorCEO();
            //SalariesGenerator salariesGenerator = new SalariesGenerator();
            var salaries = provider.Load();


            var retirementSalary = 0;
            //var retirementSalary2 = 0;

            //lock (retirementCalculator)
            //{
                retirementSalary = retirementCalculator.Process(salaries, employee);
                //retirementSalary2 = retirementCalculator2.Process(salaries, employee); //issue with access on File as a shared resource

            //}

            logger.Log($"Your retirement salary will be {retirementSalary}");
            logger.Log(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }

}

