using NUnit.Framework;

namespace Lesson1_SRP.Tests
{
    public class RetirementRulesProvider2021Test
    {
        [Test]
        public void GetBonuses_SalaryOver50000_ExpectBonus2000()
        {
            //arrange
            var rulesProvider = new RetirementRulesProvider2021();
            var salaries = new List<Salary>();
            salaries.Add(new Salary() { Value = 55000 });
            //act
            var result = rulesProvider.GetBonuses(salaries);
            //assert
            Assert.AreEqual(2000, result);
        }

        [Test]
        public void GetBonuses_SalaryUnder45000_ExpectNoBonus()
        {
            //arrange
            var rulesProvider = new RetirementRulesProvider2021();
            var salaries = new List<Salary>();
            salaries.Add(new Salary(){Value = 44000});
            //act
            var result = rulesProvider.GetBonuses(salaries);
            //assert
            Assert.AreEqual(0, result);
        }

        [TestCase(47001, 2000, Category=TestCategories.Positive)]
        [TestCase(47000, 0, Category=TestCategories.Positive)]
        [TestCase(0, 0, Category= TestCategories.Negative)]
        [TestCase(-1, 0, Category= TestCategories.Negative)]
        [TestCase(999999999, 2000, Category= TestCategories.Positive)]
        [Category(TestCategories.UnitTest)]

        public void GetBonuses_Salary_ExpectedBonus(int salary, int expectedBonus)
        {
            //arrange
            var rulesProvider = new RetirementRulesProvider2021();
            var salaries = new List<Salary>();
            salaries.Add(new Salary(){Value = salary});
            //act
            var actual = rulesProvider.GetBonuses(salaries);
            //assert
            Assert.AreEqual(expectedBonus, actual);
        }

    }
}