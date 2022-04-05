using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Lesson1_SRP.RulesProviders;
using Lesson1_SRP.Entities;

namespace Lesson1_SRP.Tests
{
    [Fact]
    public void Calculate()
    {
        var salaries = new List<Salary>();
        for(int i = 0; i < 1; i++)
        {
            salaries.Add(new Salary()
            {
                Value = 1,
                DateTime = new DateTime(2020, 1, 1)
            });
        }
        var multiplication = 1.0;

        //IMultiplicationRulesProvider multiplicationRulesProvider = null;
        //IRulesForBonusesProvider rulesForBonusesProvider = null;
        var multiplicationRulesProviderMock = new Mock<IMultiplicationRulesProvider>(MockBehavior.Strict);
        var rulesForBonusesProviderMock = new Mock<IRulesForBonusesProvider>(MockBehavior.Strict);

        multiplicationRulesProviderMock.Setup(mrp => Multiplicate)
        //Arrange
        var retirementCalculator = new RetirementCalculator(rulesForBonusesProviderMock.Object, multiplicationRulesProviderMock.Object);
        var worker = new Worker();

        //Act
        var result = retirementCalculator.Calculate(worker);

        //Assert
    }

}
}
