using Lesson1_SRP;
using Moq;
using NUnit.Framework;
using System;

namespace Lesson1_SRP.Tests
{
    [TestFixture]
    public class RetirementCalculatorTests
    {
        private MockRepository mockRepository;

        private Mock<IRetirementRulesProvider> mockRetirementRulesProvider;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockRetirementRulesProvider = this.mockRepository.Create<IRetirementRulesProvider>();
        }

        private RetirementCalculator CreateRetirementCalculator()
        {
            return new RetirementCalculator(
                this.mockRetirementRulesProvider.Object);
        }

        [Test]
        public void Process_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var retirementCalculator = this.CreateRetirementCalculator();
            List <Salary> salaries = null;
            int baseRetirementSalary = 0;

            // Act
            var result = retirementCalculator.Process(
                salaries,
                baseRetirementSalary);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}
