using Moq;
using NUnit.Framework;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTest
    {
        [TestCase(10000, 2, 3, 20003)]
        [TestCase(10000, 0, 0, 0)]
        [TestCase(10000, -1, -1, -10001)]
        [TestCase(0, 2, 3, 3)]
        [TestCase(0, -1, -1, -1)]
        [TestCase(-1, -1, -1, 0)]
        [TestCase(-1, -1, 1, 2)]
        public void POC_Process_MockingTest(int baseRetirementSalary, int multiplication, int bonuses, int expectedResult)
        {
            //arrange
            //var retirementRulesProvider2021 = new RetirementRulesProvider2021();
            var retirementRulesProviderMock = new Mock<IRetirementRulesProvider>(MockBehavior.Strict);
            retirementRulesProviderMock.Setup(rrp => rrp.GetMultiplication(It.IsAny<List<Salary>>())).Returns(multiplication);
            retirementRulesProviderMock.Setup(rrp => rrp.GetBonuses(It.IsAny<List<Salary>>())).Returns(bonuses);
            var retirementCalculator = new RetirementCalculator(retirementRulesProviderMock.Object);
            var salaries = new List<Salary>();
            
            //act
            var actualResult = retirementCalculator.Process(salaries, baseRetirementSalary);

            //assert
            Assert.AreEqual(expectedResult, actualResult, $"CHECK: Calculation of retirement failed:");
        }
        //TODO continue: CleanUp test to make sense (negative values)

    }
}