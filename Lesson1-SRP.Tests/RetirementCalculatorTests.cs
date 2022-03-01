using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTests
    {
        [Fact]
        public void BasicTest_RetirementCalculator()
        {
            // arrange
            var multiplicationProviderMock = new Mock<IMultiplicationProvider>();
            var bonusesProviderMock = new Mock<IBonusesProvider>();

            var retirementCalculator = new RetirementCalculator(
                multiplicationProviderMock.Object,
                bonusesProviderMock.Object);

            var listOfSalaries = new List<Salary>
            {
                new() { DateTime = DateTime.Now, Value = 25000 },
                new() { DateTime = DateTime.Now, Value = 25000 },
                new() { DateTime = DateTime.Now, Value = 25000 }
            };

            var employee = new Employee();

            // act
            var actualResult = retirementCalculator.CalculateRetirementMonthlySalary(listOfSalaries, employee);

            // assert
            Assert.True(actualResult != 0);
        }
    }
}
