using System.Diagnostics.CodeAnalysis;
using Moq;
using NUnit.Framework;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTest
    {
        [TestCase(10000, 2, 3, 20003)]
        [TestCase(10000, 0.001, 0, 10)]
        [TestCase(0, 2, 3, 3)]
        [TestCase(-10000, 2, 3, 3)]

        public void Proces_ValidInputs_ExpectedOutputs(int baseRetirementSalary, double multiplication, int bonuses, int expectedResult)
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
        
        [Test]
        public void Process_NegativeBaseSalary_ExpectedExceptionThrown()
        {
            //arrange
            var baseRetirementSalary = -5;
            //var retirementRulesProvider2021 = new RetirementRulesProvider2021();
            var retirementRulesProviderMock = new Mock<IRetirementRulesProvider>(MockBehavior.Strict);
            retirementRulesProviderMock.Setup(rrp => rrp.GetMultiplication(It.IsAny<List<Salary>>())).Returns(2);
            retirementRulesProviderMock.Setup(rrp => rrp.GetBonuses(It.IsAny<List<Salary>>())).Returns(3);
            var retirementCalculator = new RetirementCalculator(retirementRulesProviderMock.Object);
            var salaries = new List<Salary>();

            //act
            Assert.Throws<NegativeSalaryException>(() => retirementCalculator.Process(salaries, baseRetirementSalary),"Expected exception was not thrown.");
            //var actualResult = retirementCalculator.Process(salaries, baseRetirementSalary);

            //assert
            //Assert.AreEqual(expectedResult, actualResult, $"CHECK: Calculation of retirement failed:");
        }

        //
        //Debug Exception and check call stacks
        //TODO create Mock Repository
        //TODO use boiler Template Test

    }
}