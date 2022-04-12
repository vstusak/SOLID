using Lesson1_SRP.Entities;
using Lesson1_SRP.RulesProviders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

namespace Lesson1_SRP.Tests
{
    public class RetirementCalculatorTests
    {
        [Fact]
        public void Calculate()
        {
            //var salaries = new List<Salary>();
            //for (int i = 0; i < 1; i++)
            //{
            //    salaries.Add(new Salary()
            //    {
            //        Value = 1,
            //        DateTime = new DateTime(2020, 1, 1)
            //    });
            //}
            //var multiplication = 1.0;

            //IRulesForBonusesProvider rulesForBonusesProvider = null;
            //IMultiplicationRulesProvider multiplicationRulesProvider = null;

            var multiplicationRulesProviderMock = new Mock<IMultiplicationRulesProvider>(MockBehavior.Strict);
            //multiplicationRulesProviderMock.Setup(mrp => mrp.ApplyRulesForMultiplication(salaries, multiplication)).Returns(2);
            multiplicationRulesProviderMock.Setup(mrp => mrp.ApplyRulesForMultiplication(It.IsAny<IEnumerable<Salary>>(), It.IsAny<double>())).Returns(2);
            //nedovolí přiřazení hodnoty, nikdy to neudělá nic jinýho :) <3 pro Vláďu
            //multiplicationRulesProviderMock.Setup(mrp => mrp.Year).Returns(2);
            multiplicationRulesProviderMock.SetupProperty(mrp => mrp.Year, 1955);
            multiplicationRulesProviderMock.SetupProperty(mrp => mrp.Address.Street.Name, "Ulicova");

            var rulesForBonusesProviderMock = new Mock<IRulesForBonusesProvider>(MockBehavior.Strict);
            rulesForBonusesProviderMock.Setup(rfbp => rfbp.ApplyRulesForBonuses(It.IsAny<IEnumerable<Salary>>())).Returns(new List<int> { 0, 1 });

            //multiplicationRulesProviderMock.Setup(mrp => mrp.ApplyRulesForMultiplication(salaries, multiplication)).Returns(2);

            //Arrange
            var retirementCalculator = new RetirementCalculator(rulesForBonusesProviderMock.Object, multiplicationRulesProviderMock.Object);
            var person = new Worker();

            //Act
            var result = retirementCalculator.Calculate(person);

            //Assert
            Assert.Equal(40001, result);

            multiplicationRulesProviderMock.Verify(mrp => mrp.ApplyRulesForMultiplication(It.IsAny<IEnumerable<Salary>>(), It.IsAny<double>()), Times.Exactly(1));

            Assert.Equal(2022, multiplicationRulesProviderMock.Object.Year);
            multiplicationRulesProviderMock.VerifySet(mrp => mrp.Year = 2022, Times.AtLeastOnce);
            multiplicationRulesProviderMock.VerifySet(mrp => mrp.Year = 1988);

        }
    }
}
