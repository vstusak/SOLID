using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
            var multiplicationProviderMock = new Mock<IMultiplicationProvider>(MockBehavior.Strict);
            var bonusesProviderMock = new Mock<IBonusesProvider>(MockBehavior.Strict);

            var listOfSalaries = new List<Salary>
            {
                new() { DateTime = DateTime.Now, Value = 25000 },
                new() { DateTime = DateTime.Now, Value = 25000 },
                new() { DateTime = DateTime.Now, Value = 50000 }
            };

            //multiplicationProviderMock.Setup(mpm => mpm.ApplyRules(2.0,listOfSalaries)).Returns(1.0);
            //var applyRules = mpm => mpm.ApplyRules(It.IsAny<Double>(), It.IsAny<IEnumerable<Salary>>());
            //multiplicationProviderMock.Setup(mpm => mpm.Year).Returns(1689);
            multiplicationProviderMock.SetupProperty(mpm => mpm.Year, 1969);
            Action<IMultiplicationProvider> set = mpm => mpm.Year = 2000;
            multiplicationProviderMock.SetupSet(set);

            Expression<Func<IMultiplicationProvider, double>> applyRules = mpm => mpm.ApplyRules(It.IsAny<Double>(), It.IsAny<IEnumerable<Salary>>());
            multiplicationProviderMock.Setup(applyRules).Returns(1.0);

            bonusesProviderMock
                .Setup(bpm => bpm.ApplyRules(It.IsAny<IEnumerable<Salary>>()))
                .Returns(new List<int>() { 1, 1, 1 });


            var retirementCalculator = new RetirementCalculator(
                multiplicationProviderMock.Object,
                bonusesProviderMock.Object);

            var employee = new Employee();

            // act
            var actualResult = retirementCalculator.CalculateRetirementMonthlySalary(listOfSalaries, employee);

            // assert
            Assert.Equal(1003, actualResult);
            multiplicationProviderMock.Verify();
            bonusesProviderMock.Verify();
            multiplicationProviderMock.Verify(applyRules, Times.Exactly(1));
            //multiplicationProviderMock.VerifySet(set);

            Assert.Equal(2000, multiplicationProviderMock.Object.Year);
        }
    }
}
