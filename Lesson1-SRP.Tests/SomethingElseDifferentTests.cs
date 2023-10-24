using Lesson1_SRP;
using Moq;
using NUnit.Framework;
using System;

namespace Lesson1_SRP.Tests
{
    [TestFixture]
    public class SomethingElseDifferentTests : TestBase
    {

        private Mock<IRetirementRulesProvider> _mockRetirementRulesProvider;

        [SetUp]
        public void SetUp()
        {
            _mockRetirementRulesProvider = MockRepository.Create<IRetirementRulesProvider>();
        }

        private SomethingElseDifferent CreateSomethingElseDifferent()
        {
            return new SomethingElseDifferent(
                _mockRetirementRulesProvider.Object);
        }

        [Test]
        public void Process_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var somethingElseDifferent = CreateSomethingElseDifferent();
            List<Salary> salaries = null;
            int baseRetirementSalary = 0;

            // Act
            var result = somethingElseDifferent.Process(
                salaries,
                baseRetirementSalary);

            // Assert
            Assert.Fail();
        }
    }
}
