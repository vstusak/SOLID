using System.Diagnostics.CodeAnalysis;
using Moq;
using NUnit.Framework;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTest
    {
        private Mock<IRetirementRulesProvider> _retirementRulesProviderMock;
        private MockRepository _mockRepo = new MockRepository(MockBehavior.Strict);
        [SetUp]
        public void Setup()
        {
          // _retirementRulesProviderMock = new Mock<IRetirementRulesProvider>(MockBehavior.Strict);
            
            _retirementRulesProviderMock = _mockRepo.Create<IRetirementRulesProvider>();
        }

        public void TearDown()
        {
            _mockRepo.VerifyAll();
        }

        [TestCase(10000, 2, 3, 20003)]
        [TestCase(10000, 0.001, 0, 10)]

        public void Proces_ValidInputs_ExpectedOutputs(int baseRetirementSalary, double multiplication, int bonuses, int expectedResult)
        {
            //arrange
            //var retirementRulesProvider2021 = new RetirementRulesProvider2021();
            _retirementRulesProviderMock.Setup(rrp => rrp.GetMultiplication(It.IsAny<List<Salary>>())).Returns(multiplication);
            _retirementRulesProviderMock.Setup(rrp => rrp.GetBonuses(It.IsAny<List<Salary>>())).Returns(bonuses);
            var retirementCalculator = new RetirementCalculator(_retirementRulesProviderMock.Object);
            var salaries = new List<Salary>();
            
            //act
            var actualResult = retirementCalculator.Process(salaries, baseRetirementSalary);

            //assert
            Assert.AreEqual(expectedResult, actualResult, $"CHECK: Calculation of retirement failed:");
        }
        
        [TestCase(-5)]
        [TestCase(0)]
        public void Process_NegativeBaseSalary_ExpectedExceptionThrown(int baseRetirementSalary)
        {
            //arrange
            //var baseRetirementSalary = -5;
            //var retirementRulesProvider2021 = new RetirementRulesProvider2021();
            _retirementRulesProviderMock.Setup(rrp => rrp.GetMultiplication(It.IsAny<List<Salary>>())).Returns(2);
            _retirementRulesProviderMock.Setup(rrp => rrp.GetBonuses(It.IsAny<List<Salary>>())).Returns(3);
            var retirementCalculator = new RetirementCalculator(_retirementRulesProviderMock.Object);
            var salaries = new List<Salary>();

            //act
            Assert.Throws<NegativeSalaryException>(() => retirementCalculator.Process(salaries, baseRetirementSalary), "Expected exception was not thrown.");
            //var actualResult = retirementCalculator.Process(salaries, baseRetirementSalary);

            //assert
            //Assert.AreEqual(expectedResult, actualResult, $"CHECK: Calculation of retirement failed:");

            //try
            //{
            //    retirementCalculator.Process(salaries, baseRetirementSalary);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
        }

        [Test]
        // test metoda, kontrola, zda se data nevolaji dvakrat (pomoci mock.Verify)
        [TestCase(10000, 2, 3, 20003)]
        public void Proces_ValidInputs_VerifyCallCount(int baseRetirementSalary, double multiplication, int bonuses, int expectedResult)
        {
            //arrange
            //var retirementRulesProvider2021 = new RetirementRulesProvider2021();
            _retirementRulesProviderMock.Setup(rrp => rrp.GetMultiplication(It.IsAny<List<Salary>>())).Returns(multiplication);
            _retirementRulesProviderMock.Setup(rrp => rrp.GetBonuses(It.IsAny<List<Salary>>())).Returns(bonuses);
            var retirementCalculator = new RetirementCalculator(_retirementRulesProviderMock.Object);
            var salaries = new List<Salary>();

            //act
            var actualResult = retirementCalculator.Process(salaries, baseRetirementSalary);

            //assert
            //check if GetMultiplication and GetBonuses were called exactly once
            _retirementRulesProviderMock.Verify(rrpm => rrpm.GetMultiplication(It.IsAny<List<Salary>>()),Times.Exactly(1));
            _retirementRulesProviderMock.Verify(rrpm => rrpm.GetBonuses(It.IsAny<List<Salary>>()),Times.Exactly(1));
        }

        //TODO create Mock Repository
        //TODO use boiler Template Test

    }
}