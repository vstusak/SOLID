using NUnit.Framework;

namespace Lesson1_SRP.Tests
{
    public class RetirementRulesProvider2021Test
    {
        [Test]
        public void GetBonuses_SalaryOver50000_ExpectBonus2000()
        {
            //arange
            var rulesProvider = new RetirementRulesProvider2021();
            var salaries = new List<Salary>();
            salaries.Add(new Salary(){Value = 55000});
            //act
            var result = rulesProvider.GetBonuses(salaries);
            //assert
            Assert.AreEqual(2000, result);
        }

    }
}