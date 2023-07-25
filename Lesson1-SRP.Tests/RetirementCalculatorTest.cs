using NUnit.Framework;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTest
    {
        [Test]
        public void POC_Process_MockingTest()
        {
            //arange
            var retirementRulesProvider2021 = new RetirementRulesProvider2021();
            var retirementCalculator = new RetirementCalculator(retirementRulesProvider2021);
            var salaries = new List<Salary>();
            var baseRetirementSalary = 10000;

            //act

            retirementCalculator.Process(salaries, baseRetirementSalary);

            //assert
        }
        //TODO continue: create mock of RetirementRulesProvider2021, aby metoda proces nevolala ven
    }
}