using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson1_SRP.Calculations;
using Lesson1_SRP.Entities;
using Moq;
using NUnit.Framework;

namespace Lesson1_SRP.Tests.Calculations
{
    internal class RetirementCalculatorTest
    {
        [TestCase(10000)]
        [TestCase(31000)]
        public void SentByParameter_CalculateRetirementSalary_ExpectedResultByParameter(int expectedResult)
        {
            //arrange no default -> MockBehavior.Strict + corresponding setup
            var bonusProviderMock = new Mock<IBonusProvider>(MockBehavior.Strict);
            var multiplicationProviderMock = new Mock<IMultiplicationProvider>(MockBehavior.Strict);
            
            var underTest = new RetirementCalculator(bonusProviderMock.Object, multiplicationProviderMock.Object);
            List<Salary> emptySalaryList = new List<Salary>();

            //act
            var actualResult = underTest.CalculateRetirementSalary(emptySalaryList);

            //assert
            NUnit.Framework.Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
