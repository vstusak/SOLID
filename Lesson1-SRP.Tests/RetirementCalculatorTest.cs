using Lesson1_SRP.Entities;
using Lesson1_SRP.RulesProviders;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTest
    {

        [Fact]
        public void BasicTests()
        {
            //IMultiplicationRulesProvider multiplicationRulesProvider = null;
            //IRulesForBonusesProvider rulesForBonusesProvider = null;
            var multiplicationRulesProviderMock = new Mock<IMultiplicationRulesProvider>();
            var rulesForBonusesProviderMock = new Mock<IRulesForBonusesProvider>();

            //Arrange
            var retirementCalculator = new RetirementCalculator(rulesForBonusesProviderMock.Object, multiplicationRulesProviderMock.Object);
            var worker = new Worker();

            //Act
            var result = retirementCalculator.Calculate(worker);

            //Assert
        }
       
    }
}
