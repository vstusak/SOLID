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
        [TestCase(10005, 1, 2, 3 )]
        public void SentByParameter_CalculateRetirementSalary_ExpectedResultByParameter(int expectedResult, double multiplicationResult, int bonusResult1, int bonusResult2)
        {
            //arrange no default -> MockBehavior.Strict + corresponding setup
            var bonusProviderMock = new Mock<IBonusProvider>(MockBehavior.Strict);
            var multiplicationProviderMock = new Mock<IMultiplicationProvider>(MockBehavior.Strict);
            multiplicationProviderMock.Setup(mock => 
                mock.GetMultiplication(It.IsAny<List<Salary>>())).Returns(multiplicationResult);
            bonusProviderMock.Setup(mock => mock.GetBonuses(It.IsAny<List<Salary>>()))
                .Returns(new List<int>() { bonusResult1, bonusResult2 });

            var underTest = new RetirementCalculator(bonusProviderMock.Object, multiplicationProviderMock.Object);
            List<Salary> emptySalaryList = new List<Salary>();
            
            //Retirement calculator result to be asserted
            //return Convert.ToInt32(baseSalary * multiplication + bonuses.Sum());
            
            //act
            var actualResult = underTest.CalculateRetirementSalary(emptySalaryList);

            //assert
            NUnit.Framework.Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
