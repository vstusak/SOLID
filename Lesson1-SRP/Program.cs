namespace Lesson1_SRP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var multiplicationRulesProvider = new MultiplicationRulesProvider();
            var bonusesRulesProvider = new BonusesRulesProvider();
            var retirementCalculator = new RetirementCalculator(multiplicationRulesProvider, bonusesRulesProvider);
            var employee = new Employee();
            var logger = new Logger();

            //logic to set correct role salaries
            SalariesProvider provider = new SalariesGeneratorCEO();
            //SalariesGenerator salariesGenerator = new SalariesGenerator();
            var salaries = provider.Load();

            var retirementSalary = retirementCalculator.Process(salaries, employee);

            logger.Log($"Your retirement salary will be {retirementSalary}");
            logger.Log(retirementSalary > 20000
                ? "Congratulations and have a nice retirement"
                : "You will need additional work now or in retirement, sorry");
        }
    }

}

