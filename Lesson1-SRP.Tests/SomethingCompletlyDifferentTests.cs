using Lesson1_SRP;
using Moq;
using NUnit.Framework;
using System;

namespace Lesson1_SRP.Tests
{
    [TestFixture]
    public class SomethingCompletlyDifferentTests: TestBase
    {
        private Mock<IRetirementRulesProvider> mockRetirementRulesProvider;

        [SetUp]
        public void SetUp()
        {
            mockRetirementRulesProvider = MockRepository.Create<IRetirementRulesProvider>();
        }

        private SomethingCompletlyDifferent CreateSomethingCompletlyDifferent()
        {
            return new SomethingCompletlyDifferent(
                this.mockRetirementRulesProvider.Object);
        }

        [Test]
        public void Process_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var somethingCompletlyDifferent = this.CreateSomethingCompletlyDifferent();
            List<Salary> salaries = null;
            int baseRetirementSalary = 0;

            // Act
            var result = somethingCompletlyDifferent.Process(salaries, baseRetirementSalary);

            // Assert
            Assert.Fail();
            this.MockRepository.VerifyAll();
        }
    }
}
